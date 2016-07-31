using System;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.DAL
{
    public class MyCustomDAL
    {

        public void CreateMethod1(ContentNode node)
        {
            Console.WriteLine("CreateMehod 1 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void CreateMethod2(ContentNode node)
        {
            Console.WriteLine("CreateMehod 2 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void CreateMethod3(ContentNode node)
        {
            Console.WriteLine("CreateMehod 3 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void CreateMethod4(ContentNode node)
        {
            Console.WriteLine("CreateMehod 4 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void UpdateMethod1(ContentNode node)
        {
            Console.WriteLine("UpdateMethod 1 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void UpdateMethod2(ContentNode node)
        {
            Console.WriteLine("UpdateMethod 2 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void UpdateMethod3(ContentNode node)
        {
            Console.WriteLine("UpdateMethod 3 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void UpdateMethod4(ContentNode node)
        {
            Console.WriteLine("UpdateMethod 4 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void DeleteMethod1(ContentNode node)
        {
            Console.WriteLine("DeleteMethod 1 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void DeleteMethod2(ContentNode node)
        {
            Console.WriteLine("DeleteMethod 2 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void DeleteMethod3(ContentNode node)
        {
            Console.WriteLine("DeleteMethod 3 on node {0} with document type {1}", node.Name, node.DocumentType);
        }

        public void DeleteMethod4(ContentNode node)
        {
            Console.WriteLine("DeleteMethod 4 on node {0} with document type {1}", node.Name, node.DocumentType);
        }
    }
}
