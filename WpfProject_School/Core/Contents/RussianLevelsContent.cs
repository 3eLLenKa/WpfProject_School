using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject_School.Core.CoreClasses
{
    internal class RussianLevelsContent
    {
        private string[] _firstLetters = { " ввово вовов овово вовоо оовов во ов вовво овово вово", " вов ово во овов аааооо ааоао оааоо аоаоа ооаоа ва оо", " аоаао оаоао вао ава вова авао оао лллааа ллала аллаа", " лалал аалал вал ла лалла алала вол лов алла вал аваа", " вввллл ввлвл лввлл влвлв ллвлв вова лов влввл лвлвлл", " алло олав вола лола лова вввааа аавав ваавв ава вава", " авава ввава вава алл ава в оао лала оооллл оолол лол", " олово лол ололо ллоло лава ово лово лол во овал аоав", " воаал влвао лаоов лвлоа алвво вово лава овал алла ол"};
        private string[] _secondLetters = { " aaalll aalal laall alala llala dad all alaal lalal",
                                     " fall add fall add dad ssslll sslsl lssll slsls",
                                     " llsls fall sad slssl lslsl sad salad salad ask all",
                                     " ask ;;;sss ;;s;s s;;ss ;s;s; ss;s; sad; salad;",
                                     " ;s;;s s;s;s ask; salad; sad; ask; salad; aaa;;;",
                                     " aa;a; ;aa;; a;a;a ;;a;a all; fall; a;aa; ;a;a; add;",
                                     " all; ask; dad; fall; sad; aaasss ssasa assaa salad",
                                     " ask sasas aasas dad add all sad dad lll;;; ll;l;",
                                     " ;ll;; fall; all; l;l;l ;;l;l all; fall; salad; fall;",
                                     " all; slsa; la;;s lsl;a alss; a;asl ;slla ;a;ls s;aal",
                                     " sad salad; add dad; fall all ask; dad; sad all;" };
        private string[] _thirdLetters = { };
        private string[] _fourthLetters = { };
        private string[] _fifthLetters = { };
        private string[] _sixthLetters = { };
        private string[] _seventhLetters = { };
        private string[] _eighthletters = { };

        private string[] _firstWords = { };
        private string[] _secondWords = { };
        private string[] _thirdWords = { };
        private string[] _fourWords = { };

        private string[] _firstPunctuation = { };
        private string[] _secondPunctuation = { };
        private string[] _thirdPunctuation = { };
        private string[] _fourPunctuation = { };

        private string[] _firstNumber = { };
        private string[] _secondNumber = { };
        private string[] _thirdNumber = { };
        private string[] _fourNumber = { };
        private string[] _fifthNumber = { };
        private string[] _sixNumber = { };
        private string[] _sevenNumber = { };



        public string[] firstLetters { get { return _firstLetters; } }
        public string[] secondLetters { get { return _secondLetters; } }
        public string[] thirdLetters { get { return _thirdLetters; } }
        public string[] fourthLetters { get { return _fourthLetters; } }
        public string[] fifthLetters { get { return _fifthLetters; } }
        public string[] sixthLetters { get { return _sixthLetters; } }
        public string[] seventhLetters { get { return _seventhLetters; } }
        public string[] eighthletters { get { return _eighthletters; } }

        public string[] firstWords { get { return _firstWords; } }
        public string[] secondWords { get { return _secondWords; } }
        public string[] thirdWords { get { return _thirdWords; } }
        public string[] fourWords { get { return _fourWords; } }

        public string[] firstPunctuation { get { return _firstPunctuation; } }
        public string[] secondPunctuation { get { return _secondPunctuation; } }
        public string[] thirdPunctuation { get { return _thirdPunctuation; } }
        public string[] fourPunctuation { get { return _fourPunctuation; } }

        public string[] firstNumber { get { return _firstNumber; } }
        public string[] secondNumber { get { return _secondNumber; } }
        public string[] thirdNumber { get { return _thirdNumber; } }
        public string[] fourNumber { get { return _fourNumber; } }
        public string[] fifthNumber { get { return _fifthNumber; } }
        public string[] sixNumber { get { return _sixNumber; } }
        public string[] sevenNumber { get { return _sevenNumber; } }
    }
}
