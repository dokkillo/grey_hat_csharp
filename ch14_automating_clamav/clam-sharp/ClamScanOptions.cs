using System;

namespace clamsharp
{
	public enum ClamScanOptions
	{
		CL_SCAN_RAW = 0x0,
		CL_SCAN_ARCHIVE = 0x1,
		CL_SCAN_MAIL = 0x2,
		CL_SCAN_OLE2 = 0x4,
		CL_SCAN_BLOCKENCRYPTED = 0x8,
		CL_SCAN_HTML = 0x10,
		CL_SCAN_PE = 0x20,
		CL_SCAN_BLOCKBROKEN = 0x40,
		CL_SCAN_MAILURL = 0x80,
		CL_SCAN_BLOCKMAX = 0x100,
		CL_SCAN_ALGORITHMIC = 0x200,
		CL_SCAN_PHISHING_BLOCKSSL = 0x800,
		CL_SCAN_PHISHING_BLOCKCLOAK = 0x1000,
		CL_SCAN_ELF = 0x2000,
		CL_SCAN_PDF = 0x4000,
		CL_SCAN_STRUCTRED = 0x8000,
		CL_SCAN_STRUCTURED_SSN_NORMAL = 0x10000,
		CL_SCAN_STRUCTURED_SSN_STRIPPED = 0x20000,
		CL_SCAN_PARTIAL_MESSAGE = 0x40000,
		CL_SCAN_HEURISTIC_PRECEDENCE = 0x80000,
		CL_SCAN_BLOCKMACROS = 0x100000,
		CL_SCAN_PERFORMANCE_INFO = 0x40000000,
		CL_SCAN_INTERNAL_COLLECT_SHA = 0x8000000,
		CL_SCAN_STDOPT = (CL_SCAN_ARCHIVE | CL_SCAN_MAIL | CL_SCAN_OLE2 | CL_SCAN_PDF | CL_SCAN_HTML | CL_SCAN_PE | CL_SCAN_ALGORITHMIC | CL_SCAN_ELF)
	}
}

