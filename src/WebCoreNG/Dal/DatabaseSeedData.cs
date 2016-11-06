using System;
using WebCoreNG.Dal.Entities;

namespace WebCoreNG.Dal
{
    /// <summary>
    /// Database seeds not support for .net core at this moment. 
    /// </summary>
    public class DatabaseSeedData
    {
        public static void Seed()
        {
            using (var context = new ApplicationDbContext())
            {
                var accountOne = new Account
                {
                    Name = "John Doe",
                    CompanyName = "Acme Corporation",
                    Url = "http://wwww.acmecorporation.com",
                    AlexaRank = 500000,
                    Country = "US"
                };
                var accountTwo = new Account
                {
                    Name = "Jackqueline Loo",
                    CompanyName = "Soylent Corp",
                    Url = "http://wwww.soylentcorp.com",
                    AlexaRank = 45000,
                    Country = "US"
                };
                var accountThree = new Account
                {
                    Name = "Wilmer Cowling",
                    CompanyName = "Umbrella Corporation",
                    Url = "http://wwww.umbrellacorporation.com",
                    AlexaRank = 8000000,
                    Country = "UK"
                };
                context.Accounts.Add(accountOne);
                context.Accounts.Add(accountTwo);
                context.Accounts.Add(accountThree);

                var submission = new Submission
                {
                    Id = "fUyzzyG9MzugloSJ64fF",
                    Network = "HooliAdvertiser",
                    SentEmail = "submission@hooliadvertiser.com",
                    ExpireDate = DateTime.Now.AddDays(15)
                };
                context.Submissions.Add(submission);

                context.SubmissionAccountLookups
                    .Add(new SubmissionAccountLookup
                    {
                        Id = Guid.NewGuid(),
                        Account = accountOne,
                        Submission = submission
                    });
                context.SubmissionAccountLookups
                    .Add(new SubmissionAccountLookup
                    {
                        Id = Guid.NewGuid(),
                        Account = accountTwo,
                        Submission = submission
                    });
                context.SubmissionAccountLookups
                    .Add(new SubmissionAccountLookup
                    {
                        Id = Guid.NewGuid(),
                        Account = accountThree,
                        Submission = submission
                    });

                context.SaveChanges();
            }
        }
    }
}