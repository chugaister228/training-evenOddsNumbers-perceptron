using EvenOddNumbersPerceptronStuding;

Perceptron perceptron = new Perceptron(15);

int[][] trainingData = new int[][]
        {
            new int[] { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 }, // one
            new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 }, // two
            new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // three
            new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }, // four
            new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // five
            new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 }, // six
            new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 }, // seven
            new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 }, // eight
            new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 }, // nine
        };

int[] labels = new int[]
        {
            0, 1, 0, 1, 0, 1, 0, 1, 0
        };

for (int epoch = 0; epoch < 1000; epoch++)
{
    for (int i = 0; i < trainingData.Length; i++)
    {
        perceptron.Train(trainingData[i], labels[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("---------");
}

perceptron.GetInfo();
Console.WriteLine();
Console.WriteLine("---------");

int result1 = perceptron.ProcessInputs(trainingData[0]);
int result2 = perceptron.ProcessInputs(trainingData[1]);
int result3 = perceptron.ProcessInputs(trainingData[2]);
int result4 = perceptron.ProcessInputs(trainingData[3]);
int result5 = perceptron.ProcessInputs(trainingData[4]);
int result6 = perceptron.ProcessInputs(trainingData[5]);
int result7 = perceptron.ProcessInputs(trainingData[6]);
int result8 = perceptron.ProcessInputs(trainingData[7]);
int result9 = perceptron.ProcessInputs(trainingData[8]);

Console.WriteLine();
Console.WriteLine("Results:");
Console.WriteLine("One: " + result1);
Console.WriteLine("Two: " + result2);
Console.WriteLine("Three: " + result3);
Console.WriteLine("Four: " + result4);
Console.WriteLine("Five: " + result5);
Console.WriteLine("Six: " + result6);
Console.WriteLine("Seven: " + result7);
Console.WriteLine("Eight: " + result8);
Console.WriteLine("Nine: " + result9);

Console.ReadLine();