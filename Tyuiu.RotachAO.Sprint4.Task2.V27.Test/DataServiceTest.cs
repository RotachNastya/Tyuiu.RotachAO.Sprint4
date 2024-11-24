using Tyuiu.RotachAO.Sprint4.Task2.V27.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task2.V27.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCalculate()  
   {
        DataService ds = new DataService();

        int[] numsArray = {2, 2,3,4,5,6,7,6,5,4,3,2,1};

        int res = ds.Calculate(numsArray);
        int wait = 25;
        Assert.AreEqual(wait, res);
    } 
} 
