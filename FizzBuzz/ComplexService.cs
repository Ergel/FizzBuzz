using System;
using System.IO;
using System.Threading;

namespace FizzBuzz;

public class ComplexService
{
    // This service class intentionally violates the Single Responsibility Principle (SRP)
    // by combining multiple responsibilities: business logic, logging, file I/O, scheduling, and more.

    public void ProcessDataAndGenerateReport(int input)
    {
        Log("ProcessDataAndGenerateReport started.");

        int processedData = ComplexBusinessLogic(input);

        string report = GenerateReport(processedData);
        Log("Report generated.");

        SaveReportToFile(report);

        PerformAdditionalDataCleanup(input);

        ScheduleNextRun();

        Log("ProcessDataAndGenerateReport completed.");
    }

    private int ComplexBusinessLogic(int input)
    {
        Log("ComplexBusinessLogic started.");

        // Simulate complex business logic with multiple steps
        int result = input;
        for (int i = 0; i < 10; i++)
        {
            result += ComputeFactorial(i) % 7;
            if (result % 2 == 0)
            {
                result = PerformIntermediateCalculation(result);
            }
        }

        Log("ComplexBusinessLogic completed.");
        return result;
    }

    private int ComputeFactorial(int n)
    {
        // A simple recursive factorial calculation
        if (n <= 1)
            return 1;
        return n * ComputeFactorial(n - 1);
    }

    private int PerformIntermediateCalculation(int value)
    {
        // Simulate time-consuming calculation
        Thread.Sleep(50);
        int calculation = value;
        for (int i = 0; i < 5; i++)
        {
            calculation = calculation * (i + 1) % 100;
        }
        return calculation;
    }

    private string GenerateReport(int data)
    {
        Log("GenerateReport started.");

        // Generate a pseudo report by combining various data manipulations
        string report = "=== Report Start ===\n";
        report += $"Data Value: {data}\n";
        report += "Analysis:\n";
        
        for (int i = 1; i <= 5; i++)
        {
            report += $"Metric {i}: {CalculateMetric(data, i)}\n";
        }

        report += "=== Report End ===";
        Log("GenerateReport completed.");
        return report;
    }

    private double CalculateMetric(int baseValue, int multiplier)
    {
        // Complex metric calculation
        double metric = Math.Pow(baseValue, multiplier) / (multiplier + 1);
        return Math.Round(metric, 2);
    }

    private void SaveReportToFile(string report)
    {
        Log("SaveReportToFile started.");

        try
        {
            string fileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            File.WriteAllText(fileName, report);
            Log($"Report saved to file: {fileName}");
        }
        catch (Exception ex)
        {
            Log($"Exception in SaveReportToFile: {ex.Message}");
        }

        Log("SaveReportToFile completed.");
    }

    private void PerformAdditionalDataCleanup(int input)
    {
        Log("PerformAdditionalDataCleanup started.");

        // Simulate additional processing that cleans up or archives old data
        for (int i = 0; i < 3; i++)
        {
            Log($"Cleanup iteration {i + 1} for input: {input}");
            Thread.Sleep(30);
        }

        Log("PerformAdditionalDataCleanup completed.");
    }

    private void ScheduleNextRun()
    {
        Log("ScheduleNextRun started.");

        // Simulate scheduling the next run by using a timer or thread delay
        Thread.Sleep(100);
        Log("Next run scheduled in 24 hours.");

        Log("ScheduleNextRun completed.");
    }

    private void Log(string message)
    {
        // Basic logging functionality that writes to the console and a file
        Console.WriteLine($"{DateTime.Now}: {message}");
        try
        {
            File.AppendAllText("ComplexService.log", $"{DateTime.Now}: {message}\n");
        }
        catch
        {
            // Swallow any logging exceptions to avoid impacting the main flow
        }
    }

    // Additional methods to further complicate the class

    public void ExtraOperationA(int value)
    {
        Log("ExtraOperationA started.");

        // Some arithmetic calculations
        int result = value;
        for (int i = 0; i < 20; i++)
        {
            result += i * value % (i + 1);
        }
        Log($"ExtraOperationA result: {result}");

        Log("ExtraOperationA completed.");
    }

    public void ExtraOperationB(string input)
    {
        Log("ExtraOperationB started.");

        // Simulate string manipulation and file operations combined
        string reversed = ReverseString(input);
        Log($"ExtraOperationB reversed string: {reversed}");

        // Randomly decide to write to a file
        if (input.Length % 2 == 0)
        {
            File.AppendAllText("ExtraOperationB.txt", $"{DateTime.Now} - {reversed}\n");
            Log("ExtraOperationB wrote to file.");
        }

        Log("ExtraOperationB completed.");
    }

    private string ReverseString(string input)
    {
        // Simple routine to reverse a string
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public void MixedResponsibilitiesMethod()
    {
        Log("MixedResponsibilitiesMethod started.");

        // Business logic section
        int businessResult = ComplexBusinessLogic(5);

        // Data transformation section
        string transformedData = businessResult.ToString();
        transformedData = ReverseString(transformedData);

        // Reporting section
        string report = GenerateReport(businessResult);

        // File I/O section
        SaveReportToFile(report);

        // Cleanup section
        PerformAdditionalDataCleanup(businessResult);

        Log("MixedResponsibilitiesMethod completed.");
    }
}