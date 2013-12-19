using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ManagementItem
{
    public DateTime addTime;
    public int itemType;
   
    public void setTime(DateTime time)
    {
        addTime = time;
    }
    public void setType(int type)
    {
        itemType = type;
    }
}
public class BillManagemeny:ManagementItem
{
    public int amount;
    public string reason;
    public Boolean type;
    public void setAmount(int am)
    {
        amount = am;
    }
}
public class DietManagement:ManagementItem
{
    public string amount;
    public string food;
    public DateTime time;
    public void setAmount(string am)
    {
        amount = am;
    }
}
public class ExerciseManagement : ManagementItem
{
    public string amount;
    public string exercise;
    public DateTime time;
    public void setAmount(string am)
    {
        amount = am;
    }
}
public class Management
{
    public ManagementItem[] items;
    public int index;
    public void initialize()
    {
        items = new ManagementItem[20];
        index = 0;
    }
    public void addItem(ManagementItem item)
    {
        items[index] = item;
        index++;
    }
    public void analyse()
    { 
    }
    public void deleteItem(ManagementItem item)
    {
        for (int i = 0; i < index; i++)
        {
            if (items[i] == item)
            {
                items[i] = items[index];
                index--;
            }

        }
    }

}
public class Diary
{
    public string content;
    public DateTime date;
    public string title;
    public Management management;
    public void edit(int startindex,int count,string str)
    {
        content.Remove(startindex, count);
        content.Insert(startindex, str);
    }

}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
