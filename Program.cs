using EvenOddNumbersPerceptronStuding;

Perceptron perceptron = new Perceptron(15);

int[][] trainingData = new int[][]
        {
            new int[] { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 }, // matrix for number one 
            new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 }, // matrix for number two
            new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // matrix for number three
            new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }, // matrix for number four
            new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // matrix for number five
            new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 }, // matrix for number six
            new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 }, // matrix for number seven
            new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 }, // matrix for number eight
            new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // matrix for number nine
        };


int[] labels = new int[]
        {
            0, 1, 0, 1, 0, 1, 0, 1, 0 // expected results for trained perceptron
        };

perceptron.StartTraining(labels, trainingData);

perceptron.GetInfo();

for (int i = 0; i < labels.Length; i++)
{
    Console.WriteLine($"Result for {i+1}: {perceptron.ProcessInputs(trainingData[i])}");
}

Console.ReadLine();