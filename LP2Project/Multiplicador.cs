using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP2Project
{
    public class Multiplicador
    {
        // Definindo a matriz de multiplicadores de dano
        // Linhas: 1=Fogo, 2=Água, 3=Normal, 4=Planta, 5=Elétrico
        // Colunas: 1=Fogo, 2=Água, 3=Normal, 4=Planta, 5=Elétrico
        public static double[,] danoMultiplicador = new double[5, 5]
        {
            // Fogo, Água, Normal, Planta, Elétrico
            { 1.0, 0.5, 1.0, 2.0, 1.0 }, // Fogo
            { 2.0, 1.0, 1.0, 0.5, 1.0 }, // Água
            { 1.0, 1.0, 1.0, 1.0, 1.0 }, // Normal
            { 0.5, 2.0, 1.0, 1.0, 0.5 }, // Planta
            { 1.0, 2.0, 1.0, 1.0, 0.5 }  // Elétrico
            //danoMultiplicador[atacante, defensor]

        };

    }
}