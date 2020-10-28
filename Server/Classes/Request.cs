﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
	public class Request
	{
		public enum RequestType
		{
			CreateClassroom,
			JoinClassroom,
			LeaveClassroom,
			Auth
		}
		public RequestType request;
	}
}
