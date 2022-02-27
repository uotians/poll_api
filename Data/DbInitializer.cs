using backend.Models;

namespace backend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PollContext context)
        {
            if (context.Polls.Any()
                && context.Options.Any())
            {
                return;
            }

            var firstOption = new Option { Title = "Earth" };
            var secondOption = new Option { Title = "Moon" };
            var thirdOption = new Option { Title = "World" };

            var polls = new Poll[]
            {
                new Poll
                    {
                        Title = "Hello",
                        Options = new List<Option>
                            {
                                firstOption,
                                secondOption,
                                thirdOption
                            }
                    }
            };

            context.Polls.AddRange(polls);
            context.SaveChanges();
        }
    }
}