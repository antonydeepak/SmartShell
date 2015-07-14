using System;
using java.io;
using java.util;
using edu.stanford.nlp.ling;
using edu.stanford.nlp.tagger.maxent;
using Console = System.Console;

namespace StanfordNLP
{
    class Program
    {
        const string modelsDirectory = @"C:\Users\anthoma\Google Drive\Programming_Workspace\project_workspace\smartshell\stanford_postagger\models";
        static string wsjtagger = System.IO.Path.Combine(modelsDirectory, "wsj-0-18-bidirectional-nodistsim.tagger");

        static void Main(string[] args)
        {
            var tagger = new MaxentTagger(wsjtagger);

            // Text for tagging
            //      Intent of the command
            //      Variations of the command - all mapped to the same intent.
            // find antony in test.txt - 
            // 
            var sentences = MaxentTagger.tokenizeText(new StringReader(text)).toArray();
            foreach (ArrayList sentence in sentences)
            {
                var taggedSentence = tagger.tagSentence(sentence);
                Console.WriteLine(Sentence.listToString(taggedSentence, false));
            }
        }
    }
}
