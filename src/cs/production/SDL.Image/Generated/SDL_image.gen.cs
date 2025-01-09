
// <auto-generated>
//  This code was generated by the following tool on 2023-12-01 09:51:26 GMT-05:00:
//      https://github.com/bottlenoselabs/c2cs (v0.0.0.0)
//
//  Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ReSharper disable All

#region Template
#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS8981
using bottlenoselabs.C2CS.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#endregion

using static bottlenoselabs.SDL;

namespace bottlenoselabs;

public static unsafe partial class SDL_image
{
    private const string LibraryName = "SDL_image";

    #region API

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_FreeAnimation", CallingConvention = CallingConvention.Cdecl)]
    public static extern void IMG_FreeAnimation(IMG_Animation* anim);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_Init", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_Init(int flags);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_Linked_Version", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_version* IMG_Linked_Version();

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_Load", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_Load(CString file);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadAVIF_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadAVIF_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadAnimation", CallingConvention = CallingConvention.Cdecl)]
    public static extern IMG_Animation* IMG_LoadAnimation(CString file);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadAnimationTyped_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern IMG_Animation* IMG_LoadAnimationTyped_RW(SDL_RWops* src, CBool freesrc, CString type);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadAnimation_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern IMG_Animation* IMG_LoadAnimation_RW(SDL_RWops* src, CBool freesrc);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadBMP_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadBMP_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadCUR_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadCUR_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadGIFAnimation_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern IMG_Animation* IMG_LoadGIFAnimation_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadGIF_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadGIF_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadICO_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadICO_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadJPG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadJPG_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadJXL_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadJXL_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadLBM_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadLBM_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadPCX_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadPCX_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadPNG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadPNG_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadPNM_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadPNM_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadQOI_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadQOI_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadSVG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadSVG_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadSizedSVG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadSizedSVG_RW(SDL_RWops* src, int width, int height);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTGA_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadTGA_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTIF_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadTIF_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTexture", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Texture* IMG_LoadTexture(SDL_Renderer* renderer, CString file);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTextureTyped_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Texture* IMG_LoadTextureTyped_RW(SDL_Renderer* renderer, SDL_RWops* src, CBool freesrc, CString type);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTexture_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Texture* IMG_LoadTexture_RW(SDL_Renderer* renderer, SDL_RWops* src, CBool freesrc);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadTyped_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadTyped_RW(SDL_RWops* src, CBool freesrc, CString type);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadWEBPAnimation_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern IMG_Animation* IMG_LoadWEBPAnimation_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadWEBP_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadWEBP_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadXCF_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadXCF_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadXPM_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadXPM_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_LoadXV_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_LoadXV_RW(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_Load_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_Load_RW(SDL_RWops* src, CBool freesrc);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_Quit", CallingConvention = CallingConvention.Cdecl)]
    public static extern void IMG_Quit();

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_ReadXPMFromArray", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_ReadXPMFromArray(CString* xpm);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_ReadXPMFromArrayToRGB888", CallingConvention = CallingConvention.Cdecl)]
    public static extern SDL_Surface* IMG_ReadXPMFromArrayToRGB888(CString* xpm);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_SaveJPG", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_SaveJPG(SDL_Surface* surface, CString file, int quality);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_SaveJPG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_SaveJPG_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst, int quality);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_SavePNG", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_SavePNG(SDL_Surface* surface, CString file);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_SavePNG_RW", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_SavePNG_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isAVIF", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isAVIF(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isBMP", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isBMP(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isCUR", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isCUR(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isGIF", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isGIF(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isICO", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isICO(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isJPG", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isJPG(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isJXL", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isJXL(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isLBM", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isLBM(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isPCX", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isPCX(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isPNG", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isPNG(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isPNM", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isPNM(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isQOI", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isQOI(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isSVG", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isSVG(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isTIF", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isTIF(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isWEBP", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isWEBP(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isXCF", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isXCF(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isXPM", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isXPM(SDL_RWops* src);

    [CNode(Kind = "Function")]
    [DllImport(LibraryName, EntryPoint = "IMG_isXV", CallingConvention = CallingConvention.Cdecl)]
    public static extern int IMG_isXV(SDL_RWops* src);

    #endregion

    #region Types

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public struct IMG_Animation
    {
        [FieldOffset(0)] // size = 4
        public int w;

        [FieldOffset(4)] // size = 4
        public int h;

        [FieldOffset(8)] // size = 4
        public int count;

        [FieldOffset(16)] // size = 8
        public SDL_Surface** frames;

        [FieldOffset(24)] // size = 8
        public int* delays;
    }

    [CNode(Kind = "Enum")]
    public enum IMG_InitFlags : int
    {
        IMG_INIT_JPG = 1,
        IMG_INIT_PNG = 2,
        IMG_INIT_TIF = 4,
        IMG_INIT_WEBP = 8,
        IMG_INIT_JXL = 16,
        IMG_INIT_AVIF = 32
    }

    [CNode(Kind = "MacroObject")]
    public const int SDL_IMAGE_MAJOR_VERSION = 3;

    [CNode(Kind = "MacroObject")]
    public const int SDL_IMAGE_MINOR_VERSION = 0;

    [CNode(Kind = "MacroObject")]
    public const int SDL_IMAGE_PATCHLEVEL = 0;

    #endregion
}
