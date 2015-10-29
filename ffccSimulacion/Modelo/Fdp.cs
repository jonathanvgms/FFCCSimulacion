using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meta.Numerics.Statistics.Distributions;
using Meta.Numerics.Functions;

namespace ffccSimulacion.Modelo
{
    public class Fdp
    {
        public static int Rand(int minValue, int maxValue)
        {
            Random r = new Random();

            return r.Next(minValue, maxValue);
        }

        public static double Rand()
        {
            Random r = new Random();

            return r.NextDouble();
        }

        /*
         * x: mide el tiempo
         * y: mide la cantidad que ingresa en el anden
         * m: es el máximo de la campana de gauss
         * r1, r2: son números aleatorios
         */
        public static int Normal(int minValue, int maxValue)
        {
            double r1, r2, m, x, y, mu, sigma, fx;

            if ((minValue >= maxValue) || (minValue < 0) || (maxValue < 0))
            {
                throw new System.ArgumentException("Valores incorrectos");
            }
            
            mu = calcularMedia(minValue, maxValue);

            sigma = calcularDesvio(minValue, maxValue);

            NormalDistribution f = new NormalDistribution(mu, sigma);

            m = 1 / (sigma * Math.Sqrt(2 * Math.PI));

            do
            {
                r1 = Rand();

                r2 = Rand();

                x = minValue + (maxValue - minValue) * r1;

                y = m * r2;

                fx = f.ProbabilityDensity((x - mu) / sigma);
            
            } while (y <= fx);
            
            return Convert.ToInt32(x);
        }

        private static double calcularDesvio(int minValue, int maxValue)
        {
            if (maxValue == minValue + 1)
            {
                return 1;
            }

            return (maxValue - minValue) / 2;
        }

        private static double calcularMedia(int minValue, int maxValue)
        {
            return minValue + (maxValue - minValue) / 2;
        }
                

        /*
         * minValue: es el minimo de personas que llegan al andén
         * maxValue: es el máximo de personas que llegan al andén
         * lambda: es el deltaTiempo, intervalo de tiempo (en horas)
         * 
         */ 
        public static int Gamma(int minValue, int maxValue, double lambda)
        {
            double r2, m, x, y, fx, k;
            
            if ((minValue >= maxValue) || (minValue < 0) || (maxValue < 0))
            {
                throw new System.ArgumentException("Valores incorrectos");
            }

            k = 9.0;

            GammaDistribution f = new GammaDistribution(k, lambda);

            m = (1 / lambda) * (k - 1);

            do
            {
                x = Rand();

                r2 = Rand();

                y = m * r2;

                fx = f.ProbabilityDensity(x);

            } while (y < fx);

            return Convert.ToInt32(minValue + (maxValue - minValue) * x);
        }

        /*
        * minValue: es el minimo de personas que llegan al andén
        * maxValue: es el máximo de personas que llegan al andén
        * personasPorMinuto: cantida de personas que llegan por minuto
        * cantidadEnHoras: tiempo en horas de la muestra de personas
        */ 
        public static int Poisson(int minValue, int maxValue, int personasPorMinuto, int cantidadEnHoras)
        {
            double r1, r2, m, y, fx;
            int k, lambda, x;
            
            if ((personasPorMinuto <= 0) || (cantidadEnHoras <= 0))
            {
                throw new System.ArgumentException("Valores incorrectos");
            }

            k = personasPorMinuto;

            lambda = cantidadEnHoras;

            PoissonDistribution f = new PoissonDistribution(lambda);

            m = Math.Pow(k, k) / (Math.Exp(k) * AdvancedIntegerMath.Factorial(k));

            do
            {
                r1 = Rand();

                r2 = Rand();

                x = Convert.ToInt32(minValue + (maxValue - minValue) * r1);

                y = m * r2;

                fx = f.ProbabilityMass(Convert.ToInt32(k * r1));
                
            } while (y < fx);
            
            return x;
        }
    }
}
