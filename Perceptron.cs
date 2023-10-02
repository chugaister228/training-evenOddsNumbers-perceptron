using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumbersPerceptronStuding
{
    public class Perceptron
    {
        private double[] weights;
        private double teta;
        private double learningRate = 0.1; // speed of learning

        public Perceptron(int inputCount)
        {
            Random random = new Random();

            // Set random weights [-1;1]
            weights = new double[inputCount];
            for (int i = 0; i < inputCount; i++)
            {
                weights[i] = random.NextDouble() * 2 - 1;
            }

            // Set random teta [-1;1]
            teta = random.NextDouble() * 2 - 1;
        }

        public int ProcessInputs(int[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            sum += teta;

            return (sum >= 0) ? 1 : 0;
        }

        private void Train(int[] inputs, int targetOutput)
        {
            int prediction = ProcessInputs(inputs);

            // Updating weights
            for (int i = 0; i < inputs.Length; i++)
            {
                weights[i] += learningRate * (targetOutput - prediction) * inputs[i];
            }

            // Updating teta
            teta += learningRate * (targetOutput - prediction);
        }

        private bool CheckResult(int[] labels, int[][]trainingData)
        {
            bool result = true;
            int y = 0;

            for (int i = 0; i < labels.Length; i++)
            {
                y = ProcessInputs(trainingData[i]);

                if (y != labels[i])
                {
                    result = false;
                }
            }

            return result;
        }

        public void StartTraining(int[] labels, int[][] trainingData)
        {
            while (!CheckResult(labels, trainingData))
            {
                for (int i = 0; i < trainingData.Length; i++)
                {
                    Train(trainingData[i], labels[i]);
                    GetInfo();
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Weights: ");
            for (int i = 0; i < weights.Length; i++)
            {

                Console.WriteLine(i+1 + " weight: " + weights[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Teta: " + teta);
            Console.WriteLine();
            Console.WriteLine("---------");
        }
    }
}
