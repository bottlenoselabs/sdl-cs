﻿// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System;
using bottlenoselabs.C2CS.Runtime;
using static bottlenoselabs.SDL;

namespace SDL.Samples;

internal static unsafe class Program
{
    public static readonly ProgramState State = new();

    private static int Main()
    {
        Initialize();
        LoadMedia();
        Loop();
        Close();

        return 0;
    }

    private static void Initialize()
    {
        if (SDL_Init((uint)SDL_InitFlags.SDL_INIT_VIDEO) < 0)
        {
            using var errorMessageC = SDL_GetError();
            var errorMessage = errorMessageC.ToString();
            Console.Error.WriteLine("Failed to initialize SDL. SDL error: " + errorMessage);
            Environment.Exit(1);
        }

        const string windowName = "SDL Sample: Optimized surface loading and soft stretching";
        using var windowNameC = (CString)windowName;
        State.Window = SDL_CreateWindow(
            windowNameC,
            State.ScreenWidth,
            State.ScreenHeight,
            (uint)SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
        if (State.Window == null)
        {
            using var errorMessageC = SDL_GetError();
            var errorMessage = errorMessageC.ToString();
            Console.Error.WriteLine("Failed to create window. SDL error: " + errorMessage);
            Environment.Exit(1);
        }

        State.ScreenSurface = SDL_GetWindowSurface(State.Window);
    }

    private static void Close()
    {
        SDL_DestroySurface(State.UserSurface);

        SDL_DestroyWindow(State.Window);
        State.Window = null;

        SDL_Quit();
    }

    private static void Loop()
    {
        while (true)
        {
            if (HandleEvents())
            {
                break;
            }

            Frame();
        }
    }

    private static bool HandleEvents()
    {
        SDL_Event e;
        if (!SDL_PollEvent(&e))
        {
            return false;
        }

        if (e.type == (ulong)SDL_EventType.SDL_EVENT_QUIT)
        {
            return true;
        }

        return false;
    }

    private static void Frame()
    {
        // Apply the image stretched
        SDL_Rect stretchRectangle;
        stretchRectangle.x = 0;
        stretchRectangle.y = 0;
        stretchRectangle.w = State.ScreenWidth;
        stretchRectangle.h = State.ScreenHeight;
        SDL_BlitSurfaceScaled(State.UserSurface, default, State.ScreenSurface, &stretchRectangle);

        // flip back and front buffer
        SDL_UpdateWindowSurface(State.Window);
    }

    private static void LoadMedia()
    {
        State.UserSurface = LoadSurface(AppContext.BaseDirectory + "/stretch.bmp");
    }

    private static SDL_Surface* LoadSurface(string filePath)
    {
        using var filePathC = (CString)filePath;
        var loadedSurface = SDL_LoadBMP(filePathC);
        if (loadedSurface == null)
        {
            using var errorMessageC = SDL_GetError();
            var errorMessage = errorMessageC.ToString();
            Console.Error.WriteLine("Failed to load image '{0}'. SDL error: {1}", filePath, errorMessage);
            return null;
        }

        // Optimize the image so be the same pixel format as the screen
        var optimizedSurface = SDL_ConvertSurface(loadedSurface, State.ScreenSurface->format);
        if (optimizedSurface == null)
        {
            using var errorMessageC = SDL_GetError();
            var errorMessage = errorMessageC.ToString();
            Console.Error.WriteLine("Failed to optimize image '{0}'. SDL error: {1}", filePath, errorMessage);
        }

        SDL_DestroySurface(loadedSurface);
        return optimizedSurface;
    }
}
