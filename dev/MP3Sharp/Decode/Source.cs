// /***************************************************************************
//  *   Source.cs.cs
//  *   Copyright (c) 2015 Zane Wagner, Robert Burke,
//  *   the JavaZoom team, and others.
//  * 
//  *   All rights reserved. This program and the accompanying materials
//  *   are made available under the terms of the GNU Lesser General Public License
//  *   (LGPL) version 2.1 which accompanies this distribution, and is available at
//  *   http://www.gnu.org/licenses/lgpl-2.1.html
//  *
//  *   This library is distributed in the hope that it will be useful,
//  *   but WITHOUT ANY WARRANTY; without even the implied warranty of
//  *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  *   Lesser General Public License for more details.
//  *
//  ***************************************************************************/
namespace MP3Sharp.Decode
{
	using System;
	/// <summary> Work in progress.
	/// 
	/// Class to describe a seekable data source. 
	/// 
	/// </summary>
	
	internal struct Source_Fields
    {
	    public readonly static long LENGTH_UNKNOWN = - 1;
	}

	internal interface Source
	{
	bool Seekable
		{
			get;
				
		}

	int read(sbyte[] b, int offs, int len);

	bool willReadBlock();

	long length();

	long tell();

	long seek(long pos);
	}
}