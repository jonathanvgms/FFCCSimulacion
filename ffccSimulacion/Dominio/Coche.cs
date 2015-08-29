using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffccSimulacion.Dominio
{
    [Table(Name = "Coches")]
    public class Coche
    {
        private string _modelo;
        private int _isLocomotora;
        private TipoConsumo _tipoConsumo;
        private int _consumoMovimiento;
        private int _consumoParado;
        private int _pasajerosSentados;
        private int _pasajerosParados;
        private int _cantidadAsientos;
        private int _capacidadLegal;
        private int _capacidadMaxima;

        /*Constructor para LINQ. No modificar porque se rompe el mapeo con la base de datos*/
        public Coche() { }

        public Coche(string modelo,bool esunalocomotora,TipoConsumo tipo,int consumoMov,int consumoPa,int cantidadAsientos, int capacidadLegal, int capacidadMaxima)
        {
            if (cantidadAsientos <= capacidadLegal && capacidadLegal <= capacidadMaxima)
            {
                _pasajerosSentados = 0;
                _pasajerosParados = 0;
                _modelo = modelo;
                IsLocomotora = esunalocomotora;
                _tipoConsumo = tipo;
                _consumoMovimiento = consumoMov;
                _consumoParado = consumoPa;
                _cantidadAsientos = cantidadAsientos;
                _capacidadLegal = capacidadLegal;
                _capacidadMaxima = capacidadMaxima;
            }
            else
            {
                throw new ApplicationException("Error de configuración de Coche.");
            }
        }

        #region Propiedades

        [Column(Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Modelo", DbType = "varchar(100)", CanBeNull = false)]
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        [Column(Name = "EsLocomotora", DbType = "int", CanBeNull = false)]
        public bool IsLocomotora
        {
            get { return _isLocomotora == 1; }
            set 
            { 
                if (value)
                    _isLocomotora = 1; 
                else 
                    _isLocomotora = 0; 
            }
        }

        [Column(Name = "TipoConsumo", DbType = "int", CanBeNull = false)]
        public TipoConsumo TipoConsumo
        {
            get { return _tipoConsumo; }
            set { _tipoConsumo = value; }
        }

        [Column(Name = "ConsumoMovimiento", DbType = "int", CanBeNull = false)]
        public int ConsumoMovimiento
        {
            get { return _consumoMovimiento; }
            set { _consumoMovimiento = value; }
        }

        [Column(Name = "ConsumoParado", DbType = "int", CanBeNull = false)]
        public int ConsumoParado
        {
            get { return _consumoParado; }
            set { _consumoParado = value; }
        }

        [Column(Name = "CantidadAsientos", DbType = "int", CanBeNull = false)]
        public int CantidadAsientos
        {
            get { return _cantidadAsientos; }
            set { _cantidadAsientos = value; }
        }

        [Column(Name = "MaximoLegalPasajeros", DbType = "int", CanBeNull = false)]
        public int CapacidadLegal
        {
            get { return _capacidadLegal; }
            set { _capacidadLegal = value; }
        }

        [Column(Name = "CapacidadMaximaPasajeros", DbType = "int", CanBeNull = false)]
        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set { _capacidadMaxima = value; }
        }

        public int PasajerosSentados
        {
            get { return _pasajerosSentados; }
            set { _pasajerosSentados = value; }
        }

        public int PasajerosParados
        {
            get { return _pasajerosParados; }
            set { _pasajerosParados = value; }
        }

        #endregion

        #region Metodos

        public int asientosRestantes()
        {
            return _cantidadAsientos - _pasajerosSentados;
        }

        public int capacidadLegalRestante()
        {
            return _capacidadLegal - _pasajerosSentados - _pasajerosParados;
        }

        public int capacidadMaximaRestante()
        {
            return _capacidadMaxima - _pasajerosSentados - _pasajerosParados;
        }

        public int recibir(int pasajerosASubir)
        {
            int exceso = pasajerosASubir;

            //PRIMERO SE SIENTAN LA MAYOR CANTIDAD POSIBLE DE PASAJEROS
            int pasajerosASentar;
            if (exceso >= asientosRestantes())
            {
                pasajerosASentar = asientosRestantes();
            }
            else
            {
                pasajerosASentar = exceso;
            }
            exceso -= pasajerosASentar;
            _pasajerosSentados += pasajerosASentar;

            //EL RESTO DE LOS PASAJEROS VAN PARADOS HASTA LA CAPACIDAD LEGAL
            int pasajerosAEntrar;
            if (exceso >= capacidadLegalRestante())
            {
                pasajerosAEntrar = capacidadLegalRestante();
            }
            else
            {
                pasajerosAEntrar = exceso;
            }
            exceso -= pasajerosAEntrar;
            _pasajerosParados += pasajerosAEntrar;

            //EL RESTO DE LOS PASAJEROS VAN PARADOS HASTA LA CAPACIDAD MAXIMA
            if (exceso >= capacidadMaximaRestante())
            {
                pasajerosAEntrar = capacidadMaximaRestante();
            }
            else
            {
                pasajerosAEntrar = exceso;
            }
            exceso -= pasajerosAEntrar;
            _pasajerosParados += pasajerosAEntrar;

            //EL RESTO DE LOS PASAJEROS NO PODRA ENTRAR
            return exceso;
        }

        /*Procesa el desenso de pasajeros en el coche. Retorna la cantidad de pasajeros total que desendio del coche*/
        public int DesenderPasajeros()
        {
            Random rnd = new Random();
            int genteSentadaDesciende = rnd.Next(1, 20);
            int genteParadaDesciende = rnd.Next(1, 20);

            if (genteSentadaDesciende >= _pasajerosSentados)
                _pasajerosSentados = 0;
            else
                _pasajerosSentados = _pasajerosSentados - genteSentadaDesciende;

            if (genteParadaDesciende >= _pasajerosParados)
                _pasajerosParados = 0;
            else
                _pasajerosParados = _pasajerosParados - genteParadaDesciende;

            return genteParadaDesciende + genteSentadaDesciende;
        }

        #endregion
    }
}
