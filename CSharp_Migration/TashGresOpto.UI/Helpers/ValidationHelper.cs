using System;
using System.Collections.Generic;

namespace TashGresOpto.UI.Helpers;

/// <summary>
/// Помощник для валидации вводимых данных
/// </summary>
public class ValidationHelper
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        
        public string GetErrorMessage()
        {
            return string.Join("\n", Errors);
        }
    }

    /// <summary>
    /// Валидация технологических параметров для расчета по вахтам
    /// </summary>
    public static ValidationResult ValidateBaxtaParams(
        double thw, double tug, double o2, double tk, double pop,
        double top, double tpp, double tpw, double dro, int pwd, double tim)
    {
        var result = new ValidationResult { IsValid = true };

        // Температура холодной воды (обычно 10-30°C)
        if (thw < 0 || thw > 50)
        {
            result.IsValid = false;
            result.Errors.Add("Температура холодной воды должна быть в диапазоне 0-50°C");
        }

        // Температура уходящих газов (обычно 100-200°C)
        if (tug < 50 || tug > 300)
        {
            result.IsValid = false;
            result.Errors.Add("Температура уходящих газов должна быть в диапазоне 50-300°C");
        }

        // Содержание O2 (обычно 2-10%)
        if (o2 < 0 || o2 > 21)
        {
            result.IsValid = false;
            result.Errors.Add("Содержание O2 должно быть в диапазоне 0-21%");
        }

        // Температура конденсата (обычно 20-80°C)
        if (tk < 0 || tk > 100)
        {
            result.IsValid = false;
            result.Errors.Add("Температура конденсата должна быть в диапазоне 0-100°C");
        }

        // Давление острого пара (обычно 80-140 кгс/см²)
        if (pop < 50 || pop > 200)
        {
            result.IsValid = false;
            result.Errors.Add("Давление острого пара должно быть в диапазоне 50-200 кгс/см²");
        }

        // Температура острого пара (обычно 500-570°C)
        if (top < 400 || top > 600)
        {
            result.IsValid = false;
            result.Errors.Add("Температура острого пара должна быть в диапазоне 400-600°C");
        }

        // Температура промперегрева (обычно 500-570°C)
        if (tpp < 400 || tpp > 600)
        {
            result.IsValid = false;
            result.Errors.Add("Температура промперегрева должна быть в диапазоне 400-600°C");
        }

        // Температура питательной воды (обычно 150-270°C)
        if (tpw < 100 || tpw > 300)
        {
            result.IsValid = false;
            result.Errors.Add("Температура питательной воды должна быть в диапазоне 100-300°C");
        }

        // Дросселирование (обычно 0-10%)
        if (dro < 0 || dro > 20)
        {
            result.IsValid = false;
            result.Errors.Add("Дросселирование должно быть в диапазоне 0-20%");
        }

        // Признак ПВД (0 или 1)
        if (pwd != 0 && pwd != 1)
        {
            result.IsValid = false;
            result.Errors.Add("Признак ПВД должен быть 0 или 1");
        }

        // Время работы (0-24 часа)
        if (tim < 0 || tim > 24)
        {
            result.IsValid = false;
            result.Errors.Add("Время работы должно быть в диапазоне 0-24 часов");
        }

        return result;
    }

    /// <summary>
    /// Валидация данных счетчиков
    /// </summary>
    public static ValidationResult ValidateCounterData(int block, int shift, double output, double sn)
    {
        var result = new ValidationResult { IsValid = true };

        // Номер блока (1-12)
        if (block < 1 || block > 12)
        {
            result.IsValid = false;
            result.Errors.Add($"Номер блока должен быть в диапазоне 1-12 (указано: {block})");
        }

        // Номер смены (1-4)
        if (shift < 1 || shift > 4)
        {
            result.IsValid = false;
            result.Errors.Add($"Номер смены должен быть в диапазоне 1-4 (указано: {shift})");
        }

        // Выработка (не может быть отрицательной)
        if (output < 0)
        {
            result.IsValid = false;
            result.Errors.Add($"Выработка не может быть отрицательной (указано: {output})");
        }

        // Выработка слишком большая (проверка разумности)
        if (output > 1500)
        {
            result.IsValid = false;
            result.Errors.Add($"Выработка слишком велика (указано: {output}, максимум: 1500 МВт·ч)");
        }

        // СН не может быть отрицательным
        if (sn < 0)
        {
            result.IsValid = false;
            result.Errors.Add($"СН не может быть отрицательным (указано: {sn})");
        }

        // СН не может быть больше выработки
        if (sn > output)
        {
            result.IsValid = false;
            result.Errors.Add($"СН ({sn}) не может быть больше выработки ({output})");
        }

        return result;
    }

    /// <summary>
    /// Валидация данных для модуля WYRABOTKA
    /// </summary>
    public static ValidationResult ValidateWyrabotkaData(DateTime date)
    {
        var result = new ValidationResult { IsValid = true };

        // Проверка даты
        if (date > DateTime.Now.AddDays(1))
        {
            result.IsValid = false;
            result.Errors.Add("Дата не может быть в будущем");
        }

        if (date < new DateTime(1990, 1, 1))
        {
            result.IsValid = false;
            result.Errors.Add("Дата слишком старая (минимум: 1990 год)");
        }

        return result;
    }

    /// <summary>
    /// Валидация данных для модуля PEREJEG
    /// </summary>
    public static ValidationResult ValidatePerejegData(double fuelValue, int blockNumber)
    {
        var result = new ValidationResult { IsValid = true };

        // Значение расхода топлива не может быть отрицательным
        if (fuelValue < 0)
        {
            result.IsValid = false;
            result.Errors.Add($"Расход топлива не может быть отрицательным (указано: {fuelValue})");
        }

        // Номер блока (1-12)
        if (blockNumber < 1 || blockNumber > 12)
        {
            result.IsValid = false;
            result.Errors.Add($"Номер блока должен быть в диапазоне 1-12 (указано: {blockNumber})");
        }

        return result;
    }

    /// <summary>
    /// Валидация диапазона дат
    /// </summary>
    public static ValidationResult ValidateDateRange(DateTime startDate, DateTime endDate)
    {
        var result = new ValidationResult { IsValid = true };

        if (startDate > endDate)
        {
            result.IsValid = false;
            result.Errors.Add("Начальная дата не может быть позже конечной даты");
        }

        if ((endDate - startDate).TotalDays > 365)
        {
            result.IsValid = false;
            result.Errors.Add("Период не может превышать 365 дней");
        }

        if (endDate > DateTime.Now.AddDays(1))
        {
            result.IsValid = false;
            result.Errors.Add("Конечная дата не может быть в будущем");
        }

        return result;
    }

    /// <summary>
    /// Проверка, что значение находится в допустимом диапазоне
    /// </summary>
    public static bool IsInRange(double value, double min, double max)
    {
        return value >= min && value <= max;
    }

    /// <summary>
    /// Форматирование числа с проверкой
    /// </summary>
    public static bool TryParseDouble(string text, out double result)
    {
        text = text.Replace(',', '.');
        return double.TryParse(text, System.Globalization.NumberStyles.Any, 
            System.Globalization.CultureInfo.InvariantCulture, out result);
    }
}
