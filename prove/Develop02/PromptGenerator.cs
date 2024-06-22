using System;
using System.Collections.Generic;

class PromptGenerator
{
    static Random rnd = new Random();
    private List<string> _journalPrompts = new List<string>();

    public PromptGenerator()
    {
        _journalPrompts =
        [
            "What are the three things you value most in life, and why?",
            "Describe a moment when you felt truly alive and connected to yourself.",
            "What limiting beliefs do you hold about yourself, and how can you challenge them?",
            "List three areas of personal growth you’d like to focus on this year.",
            "Reflect on a past mistake or failure and what you learned from it.",
            "What does success mean to you, and how do you measure it?",
            "Describe your ideal day from start to finish. What makes it ideal?",
            "What are your greatest strengths, and how can you leverage them more effectively?",
            "Write about a fear you have and explore where it stems from.",
            "Describe a person who inspires you and the qualities you admire in them.",
            "What does authenticity mean to you, and how do you embody it in your life?",
            "Reflect on a recent challenge you faced and how you overcame it.",
            "Write a letter to your younger self, offering advice and encouragement.",
            "Describe your dream job or career path and what steps you can take to pursue it.",
            "What are your core values, and how do they influence your decisions?",
            "Reflect on a significant life change and how it has impacted you.",
            "Write about a hobby or activity that brings you joy and why it’s meaningful to you.",
            "Describe a place that makes you feel at peace and why it has that effect on you.",
            "What are three things you can do to practice self-care regularly?",
            "Reflect on a recent accomplishment and the skills or qualities that helped you achieve it.",
            "List five things you’re grateful for today and why they bring you joy.",
            "Describe a recent success or positive experience and how it made you feel.",
            "Visualize your ideal future and write about what it looks like in detail.",
            "Write a letter to your favorite fictional character, describing your life to them.",
            "Make a list of questions you would like to ask a future version of yourself."
        ];
    }

    public string GetPrompt()
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        int r = rnd.Next(_journalPrompts.Count);
        return _journalPrompts[r];
    }
}
