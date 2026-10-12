public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static double CalculateAverage(int[] numbers){
	    
	    int sum = 0;
	    foreach (int number in numbers){
		    sum += number;
	    }
	    double avg = (double)sum / numbers.Length;

	    return avg;
    }

    public static int CalculateMax(int[] numbers)
    {
	    int max = number[0];
	    foreach (int number in numbers){
		    if(max > number) 
			    max = number;
	    }
	    return max;

    }

}
