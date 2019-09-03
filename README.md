# Weather coding challenge

by: Richard Hibbitts
Designed and developed on Debian 9 Linux, using Vim, by a Python developer who's never seen C# and doesn't even own a Windows box.

## Background
The acceptance criteria for this challenge was:

    * The program should be written in C#.
    * The program should predict the weather at the RDU Airport, without making any external HTTP calls to do so.
    * The program should return the predicted temperature and precipitation for the current day (if a day was NOT passed in) or for the given day (if a day WAS passed in).
    * The response should be in JSON format.
    * The code should be well organized, documented, and unit tested.
    * Bonus points if they account for climate change >.<

A couple of notes on my interpretation of these criteria:

    * "current day" and "given day" are pretty non-specific.  This is the type of thing that should be fleshed out in backlog grooming based on the actual use case.  But for these purposes, I've unilaterally decided that correctly formatted input is a string, i.e. "01/01/2019" or "2009-12-25".

## Problems / Known Issues

    * I decided to go with the idea of a flat file for a data source, but I can't figure out how to make it go along with the build artifacts.  You may have to copy the `weather-data.txt` file into the current working directory to get it working.
    * Is it really that hard to serialize JSON in C#?  Or did I just miss something?
