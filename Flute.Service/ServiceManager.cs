// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <author name="Daniel Grunwald"/>
//     <version>$Revision: 3411 $</version>
// </file>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Flute.Service
{
	/// <summary>
	/// Maintains references to the core service implementations.
	/// </summary>
	internal static class ServiceManager
	{
		static ILoggingService loggingService = new TextWriterLoggingService(new DebugTextWriter());
		
		public static ILoggingService LoggingService {
			get { return loggingService; }
			set {
				if (value == null)
					throw new ArgumentNullException();
				loggingService = value;
			}
		}
		

#if FALSE // 
		static IMessageService messageService = new TextWriterMessageService(Console.Out);
		
		public static IMessageService MessageService {
			get { return messageService; }
			set {
				if (value == null)
					throw new ArgumentNullException();
				messageService = value;
			}
		}
#endif
	}
}
