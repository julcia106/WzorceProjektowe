// Julia Rutkowska - lab4/BEDN , lab4/FEDN  - lab4/BEDN , lab4/FEDN 

using System;
using System.Collections.Generic;

namespace labs
{
    class Singleton
    {
        static void Main(string[] args)
        {
            new Lab2Singleton().Run();
        }
    }
    public interface Lab

    {
        void Run();
    }

    class Lab2Singleton : Lab
    {
        public void Run()
        {
            getRepositories();
            getStars();
        }

        private void getRepositories()
        {
            Console.WriteLine("\nGET REPOSITORIES");
            GithubRestApi restApi = GithubRestApi.Instance();
            restApi.getBestUsers();
        }

        private void getStars()
        {
            Console.WriteLine("\nGET STARS");
            GithubRestApi restApi = GithubRestApi.Instance();
            restApi.getBestUsers();
        }
    }



    public sealed class GithubRestApi
    {


        private String host;
        private List<int> bestUserIds;
        List<int> numbers = new List<int>();

        private static GithubRestApi m_oInstance = null;

        private GithubRestApi()
        {

            this.host = "https://api.github.com";
            this.bestUserIds = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                this.bestUserIds.Add(random.Next());
            }
        }
        public static GithubRestApi Instance()
        {
            
            if (m_oInstance == null)
            {
                m_oInstance = new GithubRestApi();
            }
            return m_oInstance;
        }

        public void getBestUsers()
        {
            foreach (int userId in bestUserIds)
            {
                this.makeCall("/user/" + userId);
            }
        }

        private void makeCall(String path)
        {
            Console.WriteLine(host + path);
        }
    }
}
