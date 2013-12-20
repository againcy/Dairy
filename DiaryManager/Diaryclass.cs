using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DiaryManager
{
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
    public class BillManagement : ManagementItem
    {
        public int amount;
        public string reason;
        public int type;
        public void setAmount(int am)
        {
            amount = am;
        }
        public BillManagement(int am,int type,string rea) 
        {
            setAmount(am);
            setType(type);
            reason = rea;
        }
    }
    public class DietManagement : ManagementItem
    {
        public string amount;
        public string food;
        public DateTime time;
        public void setAmount(string am)
        {
            amount = am;
        }
        public DietManagement(string am,string fo,DateTime ti)
        {
            setAmount(am);
            food = fo;
            time = ti;
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
        public ExerciseManagement(string am,string ex,DateTime ti)
        {
            setAmount(am);
            exercise = ex;
            time = ti;
        }
    }
    public class Management
    {
        public ArrayList items;
        public Management()
        {
            items = new ArrayList();
        }
        public void addItem(ManagementItem item)
        {
            items.Add(item);
        }
        public void analyse()
        {
        }
        public void deleteItem(ManagementItem item)
        {
            items.Remove(item);
        }

    }
    public class Diary
    {
        public string content;
        public DateTime date;
        public string title;
        public Management management;
        public Diary()
        {

            
        }
        public void edit(string str)
        {
            content = str;
        }
        public string read()
        {
            return content;
        }
    }
    class Diaryclass
    {
    }
}
