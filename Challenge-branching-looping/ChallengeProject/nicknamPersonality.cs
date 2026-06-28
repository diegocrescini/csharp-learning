            for (int i = 0; i < maxPets; i++)
            {
                // 
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3].Contains("tbd") || ourAnimals[i, 3].EndsWith(": "))
                    {
                        bool validNickname = false;

                        do
                        {
                            Console.WriteLine($"Enter nickname for {ourAnimals[i, 0]}:");
                            readResult = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(readResult))
                            {
                                ourAnimals[i, 3] = "Nickname: " + readResult.ToLower();
                                validNickname = true;
                            }
                            else
                            {
                                Console.WriteLine("Nickname cannot be empty.");
                            }

                        } while (!validNickname);
                    }
                    if (ourAnimals[i, 5].Contains("tbd") || ourAnimals[i, 5].EndsWith(": "))
                    {
                        bool validPersonality = false;

                        do
                        {
                            Console.WriteLine($"Enter personality for {ourAnimals[i, 0]}:");
                            readResult = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(readResult))
                            {
                                ourAnimals[i, 5] = "Personality: " + readResult.ToLower();
                                validPersonality = true;
                            }
                            else
                            {
                                Console.WriteLine("Personality cannot be empty.");
                            }

                        } while (!validPersonality);
                    }
                }

            }
Console.WriteLine("Nickname and Personality fields are complete for all of our friends.");
Console.WriteLine("Press the Enter key to continue.");
readResult = Console.ReadLine();
            break;