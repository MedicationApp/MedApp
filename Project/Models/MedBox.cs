namespace Project.Models;

public class MedBox
{
    public int numOfDoses { get ; set ; }
    public int dosesLeft;
    public MedBox(int num)
    {
        numOfDoses = num;
        dosesLeft = num;
    }
}