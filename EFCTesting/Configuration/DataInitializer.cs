using EFCTesting.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Configuration
{
    public class DataInitializer
    {
        public DataInitializer()
        {
            using (EnglishContext context = new EnglishContext())
            {
                if (context.Tests.Count() != 0)
                {

                }
                else
                {
                    context.Tests.AddRange(
                        new Test
                        {
                            Questions = new List<Question>()
                        {
                        new Question()
                        {
                            Quest = "I'm very happy _____ in India. I really miss being there.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "to live",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have lived",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "to be lived",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to be living",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "They didn't reach an agreement ______ their differences.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "on account of",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "due",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "because",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "owing",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I wish I _____ those words. But now it's too late.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "not having said",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "have never said",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "never said",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had never said",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The woman, who has been missing for 10 days, is believed _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "to be abducted",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to be abducting",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have been abducted",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "to have been abducting",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "She was working on her computer with her baby next to _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "herself",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "her",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "her own",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "hers",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ to offend anyone, she said both cakes were equally good.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Not wanting",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "As not wanting",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "She didn't want",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Because not wanting",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ in trying to solve this problem. It's clearly unsolvable.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "There's no point",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "It's no point",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "There isn't point",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "It's no need",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Last year, when I last met her, she told me she _____ a letter every day for the last two months.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "had written",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "has written",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had been writing",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "wrote",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "He _____ robbed as he was walking out of the bank.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "had",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "did",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "got",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "were",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ forced to do anything. He acted of his own free will.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "In no way was he",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "No way he was",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "In any way he was",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "In any way was he",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "It _____ the best idea to pay for those tickets by credit card. It was too risky.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "may not have been",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "may not be",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "might not be",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "must not have been",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "They _____ in the basement for three months.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "were made sleeping",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "were made sleep",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "were made to sleep",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "made to sleep",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "We'll never know what might have happened _____ the email earlier.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "if he sent",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had he sent",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "if he has sent",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "did he sent",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "If success _____, we need to prepare ourselves for every possible scenario.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "is to be achieved",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "is achieved",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "will be achieved",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "is due to achieve",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "______ gifts to the judges.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "It's not allowed offering",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "It's not permitted to offe",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "It's not permitted offering",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "It's not allowed to offer",
                                    Correct = false,
                                }
                            }
                        }
                        }
                        }
                        ,
                    new Test
                    {
                        Questions = new List<Question>()
                        {
                        new Question()
                        {
                            Quest = "We were all very sad because George _____ to Berlin the following day.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "was leaving",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "left",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "will leave",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "is leaving",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I told her I admire everything _____ she's been doing.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "that",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "what",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "whom",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "who",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "What they did was _____ to the police.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "go",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "going",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "gone",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "went",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ at a low temperature, the ribs are tender and gelatinous.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Cooking",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Cooked",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "When cooking",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Cook",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I'm sorry _____ you all this time. It wasn't my intention.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "to be ignored",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have been ignored",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have been ignoring",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "to ignore",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ your mind, we would be grateful if you gave us a call.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "If you would change",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "If you had changed",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "If you'll change",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Were you to change",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ amazing that we can all be here today.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "There is",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "There seems",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "It seems",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "It turns",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "What ______ in my position? I had no other choice.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "would you do",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "would you have done",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "had you done",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "did you do",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I recommend getting there with plenty of time. _____, we might not get good seats.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Otherwise",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "On the contrary",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Furthermore",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "On the other hand",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "We haven't seen him in a while. I think he _____ the night of the accident.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "could have arrested",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "may be arrested",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "should have been arrested",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "might have been arrested",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ they did when they were together was fight.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "All",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "Which",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "That",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "It's",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Three in ten British dads wish they _____ in the delivery room when their child was born.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "wouldn't be",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "hadn't been",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "weren't",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "wouldn't have been",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "_____ can you find good restaurants in this place.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Somewhere",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Everywhere",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "If you know the spots",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Nowhere",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "His apology wasn't enough _____ him.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "so I forgive",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "for me to forgive",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "that I forgave",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "for me forgiving",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Massachusetts is _____ of becoming the first state to put a tax on carbon",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "on the verge",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "about",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "due to",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "bound",
                                    Correct = false,
                                }
                            }
                        }
                        }
                    },
                    new Test
                    {
                        Questions = new List<Question>()
                        {
                        new Question()
                        {
                            Quest = "We were completely exhausted, but we _____ time for a break.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "hadn't got",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "hadn't",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had not",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "didn't have",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "There's a growing list of shops that will not reopen _____ the pandemic.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "because",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "due to",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "as",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "on account",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Keeping _____ money safe while using digital payments should be a priority for everyone.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "my",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "their",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "one's",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "his",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Real friends always talk to _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "each other",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "one and the other",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "themselves",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "them",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "When I saw them, they _____, and I thought they _____ because their eyes were red.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "were arguing / had been crying",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "argued / were crying",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had been arguing / cried",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "were arguing / would cry",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "You need to _____ before you have an accident.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "get your car fixed",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "get someone fix your car",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "get to fix your car",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "get fixed your car",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I think I _____ my finger. I can't move it!",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "'m likely to break",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "'m bound to break",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "might have broken",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "might break",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The man found dead is believed _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "to be murdered",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have murdered",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "might be murdered",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to have been murdered",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "We ask citizens not to leave home _____ it’s strictly necessary.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "even if",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "unless",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "provided",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "supposing",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "You wouldn't be in prison now if you _____ out of trouble.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "had stayed",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "stayed",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "would stay",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "would have stayed",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Very young children _____ from screens. Young children learn best through real interaction.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "are supposed to learn",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "needn't learn",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "aren't meant to learn",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "shouldn't have learnt",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "After the storm, the place looked _____ it had been the stage for weeks of brutal fighting.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "as",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "as though",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "like if",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "how",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "When your train arrives, I _____ on the platform.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "will wait",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "shall wait",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "will have waited",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "will be waiting",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I won't say a word about this and _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "neither will you",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "you will either",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "you won't neither",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "you will too",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "This is _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "a Laura's friend",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "a Laura friend",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "a friend of Laura",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "a friend of Laura's",
                                    Correct = true,
                                }
                            }
                        }
                        }
                    },
                    new Test
                    {
                        Questions = new List<Question>()
                        {
                        new Question()
                        {
                            Quest = "When Sam was a small child, he _______ spend hours every day playing with stones in the garden.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "wide",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "broad",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "large",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "open",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "She invested a lot of time _____ researching the most appropriate university course.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "to",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "for",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "with",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "in",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The police claimed that they acted in self _____.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "interest",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "confidence",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "defence",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "discipline",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I _____ remember putting my briefcase down on that shelf.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "deeply",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "entirely",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "clearly",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "strongly",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "He turned _____ to be considerably older than I had imagined.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "over",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "up",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "out",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "round",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The windows in this house are in urgent _____ of replacement.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Not wanting",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "As not wanting",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "She didn't want",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Because not wanting",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Speed cameras _____ shown to reduce accidents.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "have",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "were being",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "have been",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "are being",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Life is a _____ deal easier for immigrants who can speak the local language.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "far",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "huge",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "big",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "great",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The experiment _____ testing people’s responses before and after drinking coffee.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "contained",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "incorporated",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "involved",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "consisted",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "We may be a bit late. We’re _____ in a traffic jam.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "buried",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "stuck",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "blocked",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "surrounded",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Having _____ his driving test several times, Paul finally passed at the fourth attempt.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "taken",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "made",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "had",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "attended",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Gospel music has been a major influence _____ other musical styles, especially soul.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "with",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "to",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "about",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "on",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Maintaining an accurate balance sheet is essential. _____ business you’re in.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "however",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "wherever",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "whatever",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "whenever",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "It’s _____ likely that this novel will win a literary prize.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "totally",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "deeply",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "strongly",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "highly",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "It’s no __________ for me to get Brad’s phone number - I’ll be seeing him tonight.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "point",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "wonder",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "secret",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "problem",
                                    Correct = true,
                                }
                            }
                        }
                        }
                    },
                    new Test
                    {
                        Questions = new List<Question>()
                        {
                        new Question()
                        {
                            Quest = "Who would have thought that the great champion would have to withdraw from the Anatolian Rally because of a simple ______?",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "fluctuation",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "detonation",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "expulsion",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "puncture",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I don't think that was a very _____ decision. You should've sent the documents through a courier service.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "crude",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "wise",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "unsafe",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "displeased",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "I daresay this man is _____ to stealing. He's never going to give it up.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "vulnerable",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "addicted",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "adaptable",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "unyielding",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "He was dismissed from service for his insistent ______.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "disobedience",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "unintelligibility",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "obedience",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "intelligibility",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The two brothers were living in ______ flats.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "permanent",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "accommodation",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "adjacent",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "unitarian",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Turkland was _____ a republic on October 29th, 1923.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "professed",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "proclaimed",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "prophecied",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "prosecuted",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The voter fills out the _____ at a nearby table and then places it in the box on the observer's table.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "electoral",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "suffrage",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "candidate",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "ballot",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The Queen of Sheba wore a robe ______ with diamonds and emeralds.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "adorned",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "curbed",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "loathed",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "maladjusted",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "______ were asked to choose between cavalry and infantry.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Infants",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Aviators",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Recruits",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "Veterans",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The report seems to ______ that a stiff resistance by the insurgents is to be expected.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "predict",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "present",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "prescribe",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "provoke",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "______ parents would want to see their children be educated in a least restrictive environment.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "Permissive",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "Vigorous",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Extravagant",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "Incompetent",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Her husband passed away last month. She herself is ______ an incurable disease and is in intense pain.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "remonstrated with",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "affluent in terms of",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "afflicted with",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "overly acquisitive for",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The new teacher was overly ______ with her pupils. All the rest of us teachers stood aghast at their lack of discipline.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "intolerant",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "lenient",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "judicious",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "repulsive",
                                    Correct = false,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "Finland is a(n) ______ nation. She is listed among the world's economically most competitive countries.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "insolvent",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "poverty-stricken",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "impoverished",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "affluent",
                                    Correct = true,
                                }
                            }
                        },
                        new Question()
                        {
                            Quest = "The prisoner was put in solitary ______.",
                            Answer = new List<Answer>()
                            {
                                new Answer
                                {
                                    Answ = "confinement",
                                    Correct = true,
                                },
                                new Answer
                                {
                                    Answ = "endurance",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "destitude",
                                    Correct = false,
                                },
                                new Answer
                                {
                                    Answ = "disfavour",
                                    Correct = false,
                                }
                            }
                        }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
