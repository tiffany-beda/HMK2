using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.InteropServices;

namespace TheReplicator
{
    public class ArtifactsCode
    {
        private int[] artifactsArray = new int[5];
        private int[] artifactsContents = new int[5];

        public int[] ArtifactsArray
        {
            get { return this.artifactsArray; }
            set { this.artifactsArray = value; }
        }
        public int[] ArtifactsContents
        {
            get { return this.artifactsContents; }
            set { this.artifactsContents = value; }
        }

        public ArtifactsCode()
        {
            artifactsArray = new int[5];
            artifactsContents = new int[5];
        }

        public ArtifactsCode(int[] _artifactsArray, int[] _artifactsContents)
        {
            this.ArtifactsArray = _artifactsArray;
            this.ArtifactsContents = _artifactsContents;
        }

        // Corrected: Copy from artifactsArray to artifactsContents
        public void CopyArrays()
        {
            for (int i = 0; i < artifactsArray.Length; i++)
            {
                artifactsContents[i] = artifactsArray[i];
            }
        }

        public override string ToString()
        {
            string array1 = string.Join(",", artifactsArray);
            string array2 = string.Join(",", artifactsContents);
            return $"The artifacts code: {array1} and the replicate artifacts: {array2}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers to add at the replicator:");

            ArtifactsCode Replicator = new ArtifactsCode();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                Replicator.ArtifactsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Replicator.CopyArrays(); // Copies the values from ArtifactsArray to ArtifactsContents

            Console.WriteLine("\nThe Replicator of D'To has been restored!");
            Console.WriteLine(Replicator.ToString());
        }
    }
}
