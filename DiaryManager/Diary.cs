using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    public class ManagementItem
    {
        private int _itemType;
        public int itemType
        {
            set
            {
                this._itemType = value;
                
            }
            get
            {
                return this._itemType;
            }
        }
        /*
         * 0 饮食计划
         * 1 锻炼计划
         * 2 收支记录
         * */

        public string[] events;
        /*
         * 根据不同类型的item决定有几个事件
         * 饮食计划：
         *   3个，分别为
         *      events[0]早餐吃的东西
         *      events[1]午餐
         *      events[2]晚餐
         * 锻炼计划：
         *   3个，分别为
         *      events[0]锻炼地点
         *      events[1]锻炼的所有项目
         *      events[2]锻炼的总时间
         * 收支记录：
         *   3个，分别为
         *      events[0]日收入
         *      events[1]日支出
         *      events[2]支出的项目
         * */

        public string notes;//备注

        public void setType(int type)
        {
            itemType = type;
        }
        public void initialEvents()
        {
            switch (itemType)
            {
                case 0: events = new string[3]; break;
                case 1: events = new string[3]; break;
                case 2: events = new string[3]; break;
            }
        }
    }
    
    public class Management
    {
        private bool isAsked;//判断是否询问过覆盖重复的管理项
        public ManagementItem[] items;
        public int index;
        public void initialize()
        {
            items = new ManagementItem[10];
            isAsked = false;
            index = 0;
        }

        /*判断该类型的管理项是否已经存在
         * true 存在
         * false 不存在
         * */
        public bool isExist(int type)
        {
            for (int i = 0; i < index; i++)
                if (items[i].itemType == type)
                {
                    return true;
                }
            return false;
        }
        /*添加管理项
         * 
         *   */

        public void addItem(ManagementItem item)
        {
            items[index] = item;
            index++;
        }
        /*
        public void analyse()
        {
        }
        */

        /*删除管理项
         * 返回值
         * true 成功删除
         * false 没有该类型的管理项，删除失败
         * */
        public bool deleteItem(int type)
        {
            if (index == 0) return false;
            int i;
            for (i = 0; i < index; i++)
                if (items[i].itemType == type) break ;
            if (i==index) return false;
            for (int j = i; j < index; j++)
                items[j] = items[j + 1];
            index--;
            return true;
        }

        //查看管理项
        public ManagementItem checkItem(int type)
        {
            for (int i = 0; i < index; i++)
                if (items[i].itemType == type) return items[i];
            return null;
        }

    }
    public class Diary
    {
        public string content;//set as pointer to workspace.rtf?
        public DateTime date;
        public string title;
        public string weather;
        public Management management;
        public void edit(int startindex, int count, string str)
        {
            content.Remove(startindex, count);
            content.Insert(startindex, str);
        }
        public Diary()
        {
            management = new Management();
            management.initialize();
        }
    }

}
