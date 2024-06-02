namespace PatternCollection.TemplateMethod;

public sealed class ITCandidateComparer : IComparer<Candidate>
{
    readonly float _interviewCoef = 1.8f;
    readonly float _startTimeCoef = 1.5f;
    readonly float _prevExperienceCreds = 1.2f;

    public int Compare(Candidate? x, Candidate? y)
    {
        var xScore = GetScore(x);
        var yScore = GetScore(y);

        if (xScore == yScore)
            return 0;

        return xScore > yScore ? 1 : -1;
    }

    // formula favors interview score way more then overall experience
    private float GetScore(Candidate? candidate)
    {
        if (candidate is null)
            return 0f;

        var score = 0.0f;
        score += candidate.InterviewScore * _interviewCoef;
        score += candidate.StartTimeScore * _startTimeCoef;

        if (candidate.RelevantPreviousExperience)
            score *= _prevExperienceCreds;

        return score;
    }
}
