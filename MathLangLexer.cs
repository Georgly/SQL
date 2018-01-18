// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-15 21:15:01

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int SELECT=4;
	public const int FROM=5;
	public const int WHERE=6;
	public const int ORDER_BY=7;
	public const int AS=8;
	public const int PROGRAM=9;
	public const int BLOCK=10;
	public const int FIELDS=11;
	public const int TABLES=12;
	public const int REQUEST=13;
	public const int SORT=14;
	public const int AND=15;
	public const int OR=16;
	public const int WS=17;
	public const int SL_COMMENT=18;
	public const int ML_COMMENT=19;
	public const int NUMBER=20;
	public const int FIELD=21;
	public const int TEXT=22;
	public const int DOT=23;
	public const int ADD=24;
	public const int SUB=25;
	public const int MUL=26;
	public const int DIV=27;
	public const int GE=28;
	public const int LE=29;
	public const int NEQUALS=30;
	public const int EQUALS=31;
	public const int GT=32;
	public const int LT=33;
	public const int ASSIGN=34;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_SELECT();
	partial void Leave_SELECT();

	// $ANTLR start "SELECT"
	[GrammarRule("SELECT")]
	private void mSELECT()
	{
		Enter_SELECT();
		EnterRule("SELECT", 1);
		TraceIn("SELECT", 1);
		try
		{
			int _type = SELECT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:8: ( 'select' )
			DebugEnterAlt(1);
			// MathLang.g:9:10: 'select'
			{
			DebugLocation(9, 10);
			Match("select"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SELECT", 1);
			LeaveRule("SELECT", 1);
			Leave_SELECT();
		}
	}
	// $ANTLR end "SELECT"

	partial void Enter_FROM();
	partial void Leave_FROM();

	// $ANTLR start "FROM"
	[GrammarRule("FROM")]
	private void mFROM()
	{
		Enter_FROM();
		EnterRule("FROM", 2);
		TraceIn("FROM", 2);
		try
		{
			int _type = FROM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:6: ( 'from' )
			DebugEnterAlt(1);
			// MathLang.g:10:8: 'from'
			{
			DebugLocation(10, 8);
			Match("from"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FROM", 2);
			LeaveRule("FROM", 2);
			Leave_FROM();
		}
	}
	// $ANTLR end "FROM"

	partial void Enter_WHERE();
	partial void Leave_WHERE();

	// $ANTLR start "WHERE"
	[GrammarRule("WHERE")]
	private void mWHERE()
	{
		Enter_WHERE();
		EnterRule("WHERE", 3);
		TraceIn("WHERE", 3);
		try
		{
			int _type = WHERE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:7: ( 'where' )
			DebugEnterAlt(1);
			// MathLang.g:11:9: 'where'
			{
			DebugLocation(11, 9);
			Match("where"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHERE", 3);
			LeaveRule("WHERE", 3);
			Leave_WHERE();
		}
	}
	// $ANTLR end "WHERE"

	partial void Enter_ORDER_BY();
	partial void Leave_ORDER_BY();

	// $ANTLR start "ORDER_BY"
	[GrammarRule("ORDER_BY")]
	private void mORDER_BY()
	{
		Enter_ORDER_BY();
		EnterRule("ORDER_BY", 4);
		TraceIn("ORDER_BY", 4);
		try
		{
			int _type = ORDER_BY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:10: ( 'order by' )
			DebugEnterAlt(1);
			// MathLang.g:12:12: 'order by'
			{
			DebugLocation(12, 12);
			Match("order by"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ORDER_BY", 4);
			LeaveRule("ORDER_BY", 4);
			Leave_ORDER_BY();
		}
	}
	// $ANTLR end "ORDER_BY"

	partial void Enter_AS();
	partial void Leave_AS();

	// $ANTLR start "AS"
	[GrammarRule("AS")]
	private void mAS()
	{
		Enter_AS();
		EnterRule("AS", 5);
		TraceIn("AS", 5);
		try
		{
			int _type = AS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:4: ( 'as' )
			DebugEnterAlt(1);
			// MathLang.g:13:6: 'as'
			{
			DebugLocation(13, 6);
			Match("as"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AS", 5);
			LeaveRule("AS", 5);
			Leave_AS();
		}
	}
	// $ANTLR end "AS"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 6);
		TraceIn("AND", 6);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:5: ( 'and' )
			DebugEnterAlt(1);
			// MathLang.g:14:7: 'and'
			{
			DebugLocation(14, 7);
			Match("and"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 6);
			LeaveRule("AND", 6);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 7);
		TraceIn("OR", 7);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:4: ( 'or' )
			DebugEnterAlt(1);
			// MathLang.g:15:6: 'or'
			{
			DebugLocation(15, 6);
			Match("or"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 7);
			LeaveRule("OR", 7);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_T__35();
	partial void Leave_T__35();

	// $ANTLR start "T__35"
	[GrammarRule("T__35")]
	private void mT__35()
	{
		Enter_T__35();
		EnterRule("T__35", 8);
		TraceIn("T__35", 8);
		try
		{
			int _type = T__35;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: '('
			{
			DebugLocation(16, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__35", 8);
			LeaveRule("T__35", 8);
			Leave_T__35();
		}
	}
	// $ANTLR end "T__35"

	partial void Enter_T__36();
	partial void Leave_T__36();

	// $ANTLR start "T__36"
	[GrammarRule("T__36")]
	private void mT__36()
	{
		Enter_T__36();
		EnterRule("T__36", 9);
		TraceIn("T__36", 9);
		try
		{
			int _type = T__36;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:17:9: ')'
			{
			DebugLocation(17, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__36", 9);
			LeaveRule("T__36", 9);
			Leave_T__36();
		}
	}
	// $ANTLR end "T__36"

	partial void Enter_T__37();
	partial void Leave_T__37();

	// $ANTLR start "T__37"
	[GrammarRule("T__37")]
	private void mT__37()
	{
		Enter_T__37();
		EnterRule("T__37", 10);
		TraceIn("T__37", 10);
		try
		{
			int _type = T__37;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:18:9: ','
			{
			DebugLocation(18, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__37", 10);
			LeaveRule("T__37", 10);
			Leave_T__37();
		}
	}
	// $ANTLR end "T__37"

	partial void Enter_T__38();
	partial void Leave_T__38();

	// $ANTLR start "T__38"
	[GrammarRule("T__38")]
	private void mT__38()
	{
		Enter_T__38();
		EnterRule("T__38", 11);
		TraceIn("T__38", 11);
		try
		{
			int _type = T__38;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: ';'
			{
			DebugLocation(19, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__38", 11);
			LeaveRule("T__38", 11);
			Leave_T__38();
		}
	}
	// $ANTLR end "T__38"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 12);
		TraceIn("WS", 12);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:33:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:34:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(34, 3);
			// MathLang.g:34:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(34, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(34, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 12);
			LeaveRule("WS", 12);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 13);
		TraceIn("SL_COMMENT", 13);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:39:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:40:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(40, 3);
			Match("//"); 

			DebugLocation(40, 8);
			// MathLang.g:40:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:40:36: .
					{
					DebugLocation(40, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(40, 40);
			// MathLang.g:40:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:40:40: '\\r'
				{
				DebugLocation(40, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(40, 46);
			Match('\n'); 
			DebugLocation(40, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 13);
			LeaveRule("SL_COMMENT", 13);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 14);
		TraceIn("ML_COMMENT", 14);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:44:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:45:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(45, 3);
			Match("/*"); 

			DebugLocation(45, 8);
			// MathLang.g:45:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:45:36: .
					{
					DebugLocation(45, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(45, 40);
			Match("*/"); 

			DebugLocation(45, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 14);
			LeaveRule("ML_COMMENT", 14);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 15);
		TraceIn("NUMBER", 15);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:52:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:52:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(52, 9);
			// MathLang.g:52:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:52:10: '0' .. '9'
					{
					DebugLocation(52, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(52, 21);
			// MathLang.g:52:21: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:52:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(52, 22);
				Match('.'); 
				DebugLocation(52, 26);
				// MathLang.g:52:26: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:52:27: '0' .. '9'
						{
						DebugLocation(52, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 15);
			LeaveRule("NUMBER", 15);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_FIELD();
	partial void Leave_FIELD();

	// $ANTLR start "FIELD"
	[GrammarRule("FIELD")]
	private void mFIELD()
	{
		Enter_FIELD();
		EnterRule("FIELD", 16);
		TraceIn("FIELD", 16);
		try
		{
			int _type = FIELD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:54:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:54:8: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(54, 8);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(55, 9);
			// MathLang.g:55:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(55, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FIELD", 16);
			LeaveRule("FIELD", 16);
			Leave_FIELD();
		}
	}
	// $ANTLR end "FIELD"

	partial void Enter_TEXT();
	partial void Leave_TEXT();

	// $ANTLR start "TEXT"
	[GrammarRule("TEXT")]
	private void mTEXT()
	{
		Enter_TEXT();
		EnterRule("TEXT", 17);
		TraceIn("TEXT", 17);
		try
		{
			int _type = TEXT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:58:5: ( '\"' ( FIELD )* '\"' )
			DebugEnterAlt(1);
			// MathLang.g:58:7: '\"' ( FIELD )* '\"'
			{
			DebugLocation(58, 7);
			Match('\"'); 
			DebugLocation(58, 11);
			// MathLang.g:58:11: ( FIELD )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>='0' && LA9_0<='9')||(LA9_0>='A' && LA9_0<='Z')||LA9_0=='_'||(LA9_0>='a' && LA9_0<='z')))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:58:11: FIELD
					{
					DebugLocation(58, 11);
					mFIELD(); 

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(58, 18);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TEXT", 17);
			LeaveRule("TEXT", 17);
			Leave_TEXT();
		}
	}
	// $ANTLR end "TEXT"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 18);
		TraceIn("DOT", 18);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:61:4: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:61:9: '.'
			{
			DebugLocation(61, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 18);
			LeaveRule("DOT", 18);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 19);
		TraceIn("ADD", 19);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:63:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:63:9: '+'
			{
			DebugLocation(63, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 19);
			LeaveRule("ADD", 19);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 20);
		TraceIn("SUB", 20);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:64:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:64:9: '-'
			{
			DebugLocation(64, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 20);
			LeaveRule("SUB", 20);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 21);
		TraceIn("MUL", 21);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:65:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:65:9: '*'
			{
			DebugLocation(65, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 21);
			LeaveRule("MUL", 21);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 22);
		TraceIn("DIV", 22);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:66:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:66:9: '/'
			{
			DebugLocation(66, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 22);
			LeaveRule("DIV", 22);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 23);
		TraceIn("GE", 23);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:68:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:68:11: '>='
			{
			DebugLocation(68, 11);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 23);
			LeaveRule("GE", 23);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 24);
		TraceIn("LE", 24);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:69:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:69:11: '<='
			{
			DebugLocation(69, 11);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 24);
			LeaveRule("LE", 24);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NEQUALS();
	partial void Leave_NEQUALS();

	// $ANTLR start "NEQUALS"
	[GrammarRule("NEQUALS")]
	private void mNEQUALS()
	{
		Enter_NEQUALS();
		EnterRule("NEQUALS", 25);
		TraceIn("NEQUALS", 25);
		try
		{
			int _type = NEQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:70:8: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:70:11: '<>'
			{
			DebugLocation(70, 11);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUALS", 25);
			LeaveRule("NEQUALS", 25);
			Leave_NEQUALS();
		}
	}
	// $ANTLR end "NEQUALS"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 26);
		TraceIn("EQUALS", 26);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:71:7: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:71:11: '=='
			{
			DebugLocation(71, 11);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 26);
			LeaveRule("EQUALS", 26);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 27);
		TraceIn("GT", 27);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:72:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:72:11: '>'
			{
			DebugLocation(72, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 27);
			LeaveRule("GT", 27);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 28);
		TraceIn("LT", 28);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:73:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:73:11: '<'
			{
			DebugLocation(73, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 28);
			LeaveRule("LT", 28);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 29);
		TraceIn("ASSIGN", 29);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:75:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:75:9: '='
			{
			DebugLocation(75, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 29);
			LeaveRule("ASSIGN", 29);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( SELECT | FROM | WHERE | ORDER_BY | AS | AND | OR | T__35 | T__36 | T__37 | T__38 | WS | SL_COMMENT | ML_COMMENT | NUMBER | FIELD | TEXT | DOT | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN )
		int alt10=29;
		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
		try
		{
			alt10 = dfa10.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(10); }
		switch (alt10)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: SELECT
			{
			DebugLocation(1, 10);
			mSELECT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:17: FROM
			{
			DebugLocation(1, 17);
			mFROM(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:22: WHERE
			{
			DebugLocation(1, 22);
			mWHERE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:28: ORDER_BY
			{
			DebugLocation(1, 28);
			mORDER_BY(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:37: AS
			{
			DebugLocation(1, 37);
			mAS(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:40: AND
			{
			DebugLocation(1, 40);
			mAND(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:44: OR
			{
			DebugLocation(1, 44);
			mOR(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:47: T__35
			{
			DebugLocation(1, 47);
			mT__35(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:53: T__36
			{
			DebugLocation(1, 53);
			mT__36(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:59: T__37
			{
			DebugLocation(1, 59);
			mT__37(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:65: T__38
			{
			DebugLocation(1, 65);
			mT__38(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:71: WS
			{
			DebugLocation(1, 71);
			mWS(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:74: SL_COMMENT
			{
			DebugLocation(1, 74);
			mSL_COMMENT(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:85: ML_COMMENT
			{
			DebugLocation(1, 85);
			mML_COMMENT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:96: NUMBER
			{
			DebugLocation(1, 96);
			mNUMBER(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:103: FIELD
			{
			DebugLocation(1, 103);
			mFIELD(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:109: TEXT
			{
			DebugLocation(1, 109);
			mTEXT(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:114: DOT
			{
			DebugLocation(1, 114);
			mDOT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:118: ADD
			{
			DebugLocation(1, 118);
			mADD(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:122: SUB
			{
			DebugLocation(1, 122);
			mSUB(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:126: MUL
			{
			DebugLocation(1, 126);
			mMUL(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:130: DIV
			{
			DebugLocation(1, 130);
			mDIV(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:134: GE
			{
			DebugLocation(1, 134);
			mGE(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:137: LE
			{
			DebugLocation(1, 137);
			mLE(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:140: NEQUALS
			{
			DebugLocation(1, 140);
			mNEQUALS(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:148: EQUALS
			{
			DebugLocation(1, 148);
			mEQUALS(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:155: GT
			{
			DebugLocation(1, 155);
			mGT(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:158: LT
			{
			DebugLocation(1, 158);
			mLT(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:161: ASSIGN
			{
			DebugLocation(1, 161);
			mASSIGN(); 

			}
			break;

		}

	}


	#region DFA
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x1\xFFFF\x5\xD\x5\xFFFF\x1\x1E\x1\x1F\x6\xFFFF\x1\x22\x1\x25\x1\x27"+
			"\x3\xD\x1\x2C\x1\x2D\x1\xD\x4\xFFFF\x1\x1F\x7\xFFFF\x4\xD\x2\xFFFF\x1"+
			"\x33\x1\xD\x1\x35\x2\xD\x1\xFFFF\x1\xD\x1\xFFFF\x1\x39\x1\xD\x1\x3B\x3"+
			"\xFFFF";
		private const string DFA10_eofS =
			"\x3C\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x65\x1\x72\x1\x68\x1\x72\x1\x6E\x5\xFFFF\x1\x2A\x1\x30\x6"+
			"\xFFFF\x3\x3D\x1\x6C\x1\x6F\x1\x65\x2\x30\x1\x64\x4\xFFFF\x1\x30\x7\xFFFF"+
			"\x1\x65\x1\x6D\x1\x72\x1\x65\x2\xFFFF\x1\x30\x1\x63\x1\x30\x1\x65\x1"+
			"\x72\x1\xFFFF\x1\x74\x1\xFFFF\x1\x30\x1\x20\x1\x30\x3\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7A\x1\x65\x1\x72\x1\x68\x1\x72\x1\x73\x5\xFFFF\x1\x2F\x1\x7A\x6"+
			"\xFFFF\x1\x3D\x1\x3E\x1\x3D\x1\x6C\x1\x6F\x1\x65\x2\x7A\x1\x64\x4\xFFFF"+
			"\x1\x7A\x7\xFFFF\x1\x65\x1\x6D\x1\x72\x1\x65\x2\xFFFF\x1\x7A\x1\x63\x1"+
			"\x7A\x1\x65\x1\x72\x1\xFFFF\x1\x74\x1\xFFFF\x1\x7A\x1\x20\x1\x7A\x3\xFFFF";
		private const string DFA10_acceptS =
			"\x6\xFFFF\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x2\xFFFF\x1\x10\x1\x11\x1\x12"+
			"\x1\x13\x1\x14\x1\x15\x9\xFFFF\x1\xD\x1\xE\x1\x16\x1\xF\x1\xFFFF\x1\x17"+
			"\x1\x1B\x1\x18\x1\x19\x1\x1C\x1\x1A\x1\x1D\x4\xFFFF\x1\x7\x1\x5\x5\xFFFF"+
			"\x1\x6\x1\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4\x1\x1";
		private const string DFA10_specialS =
			"\x3C\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\xA\x1\xFFFF\x2\xA\x12\xFFFF\x1\xA\x1\xFFFF\x1\xE\x5\xFFFF\x1\x6"+
				"\x1\x7\x1\x12\x1\x10\x1\x8\x1\x11\x1\xF\x1\xB\xA\xC\x1\xFFFF\x1\x9\x1"+
				"\x14\x1\x15\x1\x13\x2\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1\x5\x4"+
				"\xD\x1\x2\x8\xD\x1\x4\x3\xD\x1\x1\x3\xD\x1\x3\x3\xD",
				"\x1\x16",
				"\x1\x17",
				"\x1\x18",
				"\x1\x19",
				"\x1\x1B\x4\xFFFF\x1\x1A",
				"",
				"",
				"",
				"",
				"",
				"\x1\x1D\x4\xFFFF\x1\x1C",
				"\xA\x20\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x21",
				"\x1\x23\x1\x24",
				"\x1\x26",
				"\x1\x28",
				"\x1\x29",
				"\x1\x2A",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x3\xD\x1\x2B\x16\xD",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"\x1\x2E",
				"",
				"",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"",
				"",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"\x1\x34",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"\x1\x36",
				"\x1\x37",
				"",
				"\x1\x38",
				"",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"\x1\x3A",
				"\xA\xD\x7\xFFFF\x1A\xD\x4\xFFFF\x1\xD\x1\xFFFF\x1A\xD",
				"",
				"",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( SELECT | FROM | WHERE | ORDER_BY | AS | AND | OR | T__35 | T__36 | T__37 | T__38 | WS | SL_COMMENT | ML_COMMENT | NUMBER | FIELD | TEXT | DOT | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
