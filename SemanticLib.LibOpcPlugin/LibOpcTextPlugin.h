#pragma once

using namespace System;
using namespace SemanticLib::Core;

namespace SemanticLib { namespace LibOpcPlugin {

	public ref class LibOpcTextPlugin : ITextPlugin
	{
	public:
		LibOpcTextPlugin();

		~LibOpcTextPlugin();

		virtual ITextDocument^ CreateTextDocument(String^ fileName);

		virtual ITextDocument^ OpenTextDocument(String^ fileName);

		virtual property String^ Name
		{
			String^ get() { return "libOPC Plugin v.1.0"; }
		}

		virtual property DocumentFormat Format
		{
			DocumentFormat get() { return DocumentFormat::OfficeOpenXML; }
		}
	};
}}
