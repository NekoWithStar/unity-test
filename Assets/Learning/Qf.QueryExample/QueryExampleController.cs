

using System.Collections.Generic;
using UnityEngine;

namespace QFramework.QueryExample
{
    public class QueryExampleApp : Architecture<QueryExampleApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new StudentModel());
            this.RegisterModel(new TeacherModel());
        }
    }
    public class QueryExampleController : MonoBehaviour, IController
    {
        public IArchitecture GetArchitecture()
        {
            return QueryExampleApp.Interface;
        }
    }
    public class StudentModel : AbstractModel
    {
        public List<string> Students = new List<string>()
            {
                "Alex",
                "Bob"
            };
        protected override void OnInit()
        {

        }
    }

    public class TeacherModel : AbstractModel
    {
        public List<string> TeacherNames = new List<string>()
            {
                "Cat",
                "Dog"
            };

        protected override void OnInit()
        {

        }
    }

    /// <summary>
    /// 此处即Query 实现
    /// </summary>
    public class SchoolAllPersonCountQuery : AbstractQuery<int>
    {
        protected override int OnDo()
        {
            return this.GetModel<StudentModel>().Students.Count + 
                this.GetModel<TeacherModel>().TeacherNames.Count;
        }
    }
}