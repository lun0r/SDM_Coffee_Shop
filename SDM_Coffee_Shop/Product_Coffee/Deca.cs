﻿namespace SDM_Coffee_Shop
{
    internal class Deca : Coffee
    {
        public Deca()

        {
            Name = "Deca";
            Price = 2.99;

            Image = "deca";
            //Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\deca.jpg";

            Description = "Friedlieb Ferdinand Runge performed the first isolation of pure caffeine from coffee beans in 1820, after the poet Goethe heard about his work on belladonna extract, and requested he perform an analysis on coffee beans.[2] Though Runge was able to isolate the compound, he did not learn much about the chemistry of caffeine itself, nor did he seek to use the process commercially to produce decaffeinated coffee.";
        }
    }
}