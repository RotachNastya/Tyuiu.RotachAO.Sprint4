using Tyuiu.RotachAO.Sprint4.Task7.V29.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task7.V29.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        int rows = 4;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];
        string str = "983157642891";
        DataService ds = new DataService();
        int res = ds.Calculate(rows, columns, str);
        int wait = 38;
        Assert.AreEqual(wait, res);
    }
} 

