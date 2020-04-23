namespace OpenCoverDemo
{
    public class Calculate
    {
        public static int GetSum(int ivalue)
        {
            int sum = 0;
            for (int i = 1; i <= ivalue; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
