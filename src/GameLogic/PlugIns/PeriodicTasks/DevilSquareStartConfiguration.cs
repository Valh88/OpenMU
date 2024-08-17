﻿// <copyright file="DevilSquareStartConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlugIns.PeriodicTasks;

/// <summary>
/// The devil square start configuration.
/// </summary>
public class DevilSquareStartConfiguration : PeriodicTaskConfiguration
{
    /// <summary>
    /// Gets the default configuration for devil square.
    /// </summary>
    public static DevilSquareStartConfiguration Default =>
        new()
        {
            PreStartMessageDelay = TimeSpan.Zero,
            EntranceOpenedMessage = "Devil Square entrance is open and closes in {0} minute(s).",
            EntranceClosedMessage = "Devil Square entrance closed.",
            TaskDuration = TimeSpan.FromMinutes(25),
            Timetable = PeriodicTaskConfiguration.GenerateTimeSequence(TimeSpan.FromMinutes(240)).ToList(),
        };

    /// <summary>
    /// Gets or sets the entrance opened message.
    /// </summary>
    public string? EntranceOpenedMessage { get; set; }

    /// <summary>
    /// Gets or sets the entrance closed message.
    /// </summary>
    public string? EntranceClosedMessage { get; set; }
}