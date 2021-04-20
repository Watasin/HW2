using System;

namespace DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check_loop_process = false;
            while (check_loop_process != true)
            {
                char YOrN;
                Console.Write("Input DNA : ");
                string halfDNASequence = Console.ReadLine();
                bool checkhalfDNASequence = IsValidSequence(halfDNASequence);
                bool check_loop_halfDNASequence = false;
                if (checkhalfDNASequence == true)
                {
                    Console.WriteLine("Current half DNA sequence : " + halfDNASequence);
                    while (check_loop_halfDNASequence == false)
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        YOrN = char.Parse(Console.ReadLine());
                        if (YOrN == 'Y')
                        {
                            string y = ReplicateSeqeunce(halfDNASequence);
                            Console.WriteLine("Replicated half DNA sequence: " + y);
                            check_loop_halfDNASequence = true;
                        }
                        else if (YOrN == 'N')
                        {
                            check_loop_halfDNASequence = true;
                        }
                        else
                            Console.WriteLine("Please Input Y or N.");
                    }
                }
                else if (checkhalfDNASequence == false)
                {
                    Console.WriteLine("That half DNA sequence is Invalid.");
                    while (check_loop_halfDNASequence != true)
                    {
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        YOrN = char.Parse(Console.ReadLine());
                        if (YOrN == 'Y')
                        {
                            check_loop_halfDNASequence = true;
                        }
                        else if (YOrN == 'N')
                        {
                            check_loop_halfDNASequence = true;
                            check_loop_process = true;
                        }
                        else
                            Console.WriteLine("Please input Y or N.");
                    }
                }
                else
                    Console.WriteLine("ERROR");
            }
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}