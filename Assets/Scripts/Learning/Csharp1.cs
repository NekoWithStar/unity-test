using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;


public class  AutoCialloAttribute : Attribute
{
    
}


public class Ciallo
{
    [AutoCiallo] public string Text;
}

public class Csharp1 : MonoBehaviour
{
    public class EventArgs
    {
        public int Data { get; set; }
    }
    public event Action<EventArgs> EventHP;
    private void Start()
    {
        #region Event
        EventHP += TwiceNow;
        EventHP(new EventArgs()
        {
            Data = 0,
        });
        EventHP -= TwiceNow;
        
        if(EventHP != null)
        {
            EventHP.Invoke(new EventArgs()
            {
                Data = 20,
            });
        }
        #endregion
        #region Ciallo
        var cialloObject = new Ciallo();
        var type = cialloObject.GetType();
        var members = type.GetMembers();
        var markedMembers =
                members.Where(m => m.GetCustomAttributes(typeof(AutoCialloAttribute), false).Length != 0);
        foreach(var member in markedMembers)
        {
            var fieldInfo = markedMembers as FieldInfo;
            fieldInfo.SetValue(cialloObject, "HelloWorld");
        }
        Debug.Log(cialloObject.Text);
        #endregion
    }
    void TwiceNow(EventArgs eventArgs)
    {
        Debug.Log(eventArgs.Data);
    }
}
