class Comments
{
    private string _commenterName;
    private string _commenterText;

    public Comments()
    {
        _commenterName = "jim";
        _commenterText = "your video is stinky";
    }

    public string getCommenterName()
    {
        return _commenterName;
    }
    public string getCommentText()
    {
        return _commenterText;
    }
}