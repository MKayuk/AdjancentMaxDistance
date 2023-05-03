
namespace AdjacentMaxDistance
{
    public static class Calculator
    {
        public static int FindAdjacentMaxDistance(int[] Numbers)
        {
            int maxDistance = 0;
            int indexDistance = 0;
            int outerLoopindex = 0;

            while (outerLoopindex < Numbers.Length)
            {
                for (int innerLoopIndex = outerLoopindex + 1; innerLoopIndex < Numbers.Length; innerLoopIndex++)
                {
                    var outerLoopNumber = Numbers[outerLoopindex];
                    var innerLoopNumber = Numbers[innerLoopIndex];

                    if (Numbers.Any(number => (number > outerLoopNumber && number < innerLoopNumber) || (number > innerLoopNumber && number < outerLoopNumber)))
                        continue;
                    else
                    {
                        indexDistance = outerLoopNumber - innerLoopNumber;
                        if (indexDistance > maxDistance)
                            maxDistance = indexDistance;
                    }
                }
                outerLoopindex++;
            }
            return maxDistance;
        }
    }
}
