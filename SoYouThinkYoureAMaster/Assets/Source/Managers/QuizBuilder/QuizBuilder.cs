using System.Collections.Generic;

public static class QuizBuilder
{
    public static List<Question> BuildQuiz( List<ChampionMastery> championMasteryList )
    {
        // Test code:
        List<Question> quiz = new List<Question>();

        Question q1 = new Question();
        q1.Text = "Question 1";
        q1.AnswerList.Add(new Answer("Answer1 - Correct", true));
        q1.AnswerList.Add(new Answer("Answer2 - InCorrect", false));
        q1.AnswerList.Add(new Answer("Answer3 - InCorrect", false));
        q1.AnswerList.Add(new Answer("Answer4 - InCorrect", false));

        quiz.Add(q1);


        Question q2 = new Question();
        q2.Text = "Question 2";
        q2.AnswerList.Add(new Answer("Answer1 - InCorrect", false));
        q2.AnswerList.Add(new Answer("Answer2 - Correct", true));
        q2.AnswerList.Add(new Answer("Answer3 - InCorrect", false));
        q2.AnswerList.Add(new Answer("Answer4 - InCorrect", false));

        quiz.Add(q2);

        Question q3 = new Question();
        q3.Text = "Question 3";
        q3.AnswerList.Add(new Answer("Answer1 - InCorrect", false));
        q3.AnswerList.Add(new Answer("Answer2 - InCorrect", false));
        q3.AnswerList.Add(new Answer("Answer3 - Correct", true));
        q3.AnswerList.Add(new Answer("Answer4 - InCorrect", false));

        quiz.Add(q3);

        Question q4 = new Question();
        q4.Text = "Question 4";

        q4.AnswerList.Add(new Answer("Answer1 - InCorrect", false));
        q4.AnswerList.Add(new Answer("Answer2 - InCorrect", false));
        q4.AnswerList.Add(new Answer("Answer3 - InCorrect", false));
        q4.AnswerList.Add(new Answer("Answer4 - Correct", true));

        quiz.Add(q4);

        return quiz;
    }    
}
