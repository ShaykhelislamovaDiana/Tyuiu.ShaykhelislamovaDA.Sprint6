using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) { len++; }
            }

            

            int index = 0;
            string[] dig0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    dig0 = line.Split(' ');
                    len = dig0.Length;
                }
            }

            double[] numsArray = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('.', ',');
                    string[] dig = line.Split(' ');
                    for (int i = 0; i < len; i++)
                    {
                        numsArray[index] = Convert.ToDouble(dig[index]);
                        index++;
                    }
                }
            }

            numsArray = numsArray.Where(val => val % 5 != 0).ToArray();

            return numsArray;
        }
    }
}
