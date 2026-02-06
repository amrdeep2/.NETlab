using System.Collections.Generic;

namespace lab2.Models
{
    public class QaItem
    {
        public string Question { get; set; } = "";
        public string Answer { get; set; } = "";
    }

    public class Lab2ViewModel
    {
        public string Header { get; set; } = "About Me";
        public string FullName { get; set; } = "";
        public string StudentNumber { get; set; } = "";
        public string StudentEmailMasked { get; set; } = "";
        public string AboutParagraph { get; set; } = "";
        public string CourseExpectationsParagraph { get; set; } = "";

        public List<QaItem> QuestionsAndAnswers { get; set; } = new();
    }
}
