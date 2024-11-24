using Tyuiu.RotachAO.Sprint4.Task2.V27.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task2.V27.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCalculate()  
   {
        DataService ds = new DataService();

        int[] numsArray = { 5, 2, 2, 2, 5, 6, 4, 3, 7, 6, 4, 7, 3 };

        int res = ds.Calculate(numsArray);
        int wait = 26;
        Assert.AreEqual(wait, res);
    } 
} 
