﻿using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;
 
BenchmarkRunner.Run<StringTest>();
 
public class StringTest
{
    string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
    [Benchmark]
    public string WithStringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (string s in numbers)
        {
            stringBuilder.Append(s);
            stringBuilder.Append(" ");
        }
        return stringBuilder.ToString();
    }
    [Benchmark]
    public string WithConcatenation()
    {
        string result = String.Empty;
        foreach (string s in numbers) result = result + s + " ";
        return result;
    }
    [Benchmark]
    public string WithInterpolation()
    {
        string result = "";
        foreach (string s in numbers) result = $"{result}{s} ";
        return result;
    }
}