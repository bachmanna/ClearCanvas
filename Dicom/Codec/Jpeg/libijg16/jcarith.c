#pragma region License (non-CC)

// This source code contains the work of the Independent JPEG Group.
// Please see accompanying notice in code comments and/or readme file
// for the terms of distribution and use regarding this code.

#pragma endregion

/*
 * jcarith.c
 *
 * Copyright (C) 1991-1998, Thomas G. Lane.
 * This file is part of the Independent JPEG Group's software.
 * For conditions of distribution and use, see the accompanying README file.
 *
 * This file holds place for arithmetic entropy encoding routines.
 */

#define JPEG_INTERNALS
#include "jinclude16.h"
#include "jpeglib16.h"


/*
 * Module initialization routine for arithmetic entropy encoding.
 */

GLOBAL(void)
jinit_arith_encoder (j_compress_ptr cinfo)
{
  ERREXIT(cinfo, JERR_ARITH_NOTIMPL);
}
