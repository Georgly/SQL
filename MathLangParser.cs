// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-14 11:47:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "SELECT", "FROM", "WHERE", "ORDER_BY", "PROGRAM", "BLOCK", "FIELDS", "TABLES", "REQUEST", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "FIELD", "TEXT", "DOT", "ADD", "SUB", "MUL", "DIV", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "ASSIGN", "'('", "')'", "','", "';'"
	};
	public const int EOF=-1;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int SELECT=4;
	public const int FROM=5;
	public const int WHERE=6;
	public const int ORDER_BY=7;
	public const int PROGRAM=8;
	public const int BLOCK=9;
	public const int FIELDS=10;
	public const int TABLES=11;
	public const int REQUEST=12;
	public const int WS=13;
	public const int SL_COMMENT=14;
	public const int ML_COMMENT=15;
	public const int NUMBER=16;
	public const int FIELD=17;
	public const int TEXT=18;
	public const int DOT=19;
	public const int ADD=20;
	public const int SUB=21;
	public const int MUL=22;
	public const int DIV=23;
	public const int GE=24;
	public const int LE=25;
	public const int NEQUALS=26;
	public const int EQUALS=27;
	public const int GT=28;
	public const int LT=29;
	public const int ASSIGN=30;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[43+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:75:1: group : ( '(' term ')' | NUMBER | TEXT | table_field | '(' exprList ')' );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken NUMBER4=null;
		IToken TEXT5=null;
		IToken char_literal7=null;
		IToken char_literal9=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);
		MathLangParser.table_field_return table_field6 = default(MathLangParser.table_field_return);
		MathLangParser.exprList_return exprList8 = default(MathLangParser.exprList_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER4_tree=null;
		object TEXT5_tree=null;
		object char_literal7_tree=null;
		object char_literal9_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(75, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:75:6: ( '(' term ')' | NUMBER | TEXT | table_field | '(' exprList ')' )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 31:
				{
				int LA1_1 = input.LA(2);

				if (((LA1_1>=NUMBER && LA1_1<=TEXT)||LA1_1==31))
				{
					alt1=1;
				}
				else if ((LA1_1==SELECT))
				{
					alt1=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NUMBER:
				{
				alt1=2;
				}
				break;
			case TEXT:
				{
				alt1=3;
				}
				break;
			case FIELD:
				{
				alt1=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:76:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 6);
				char_literal1=(IToken)Match(input,31,Follow._31_in_group586); if (state.failed) return retval;
				DebugLocation(76, 8);
				PushFollow(Follow._term_in_group589);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(76, 16);
				char_literal3=(IToken)Match(input,32,Follow._32_in_group591); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:77:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(77, 3);
				NUMBER4=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group596); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER4_tree = (object)adaptor.Create(NUMBER4);
				adaptor.AddChild(root_0, NUMBER4_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:78:3: TEXT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(78, 3);
				TEXT5=(IToken)Match(input,TEXT,Follow._TEXT_in_group600); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TEXT5_tree = (object)adaptor.Create(TEXT5);
				adaptor.AddChild(root_0, TEXT5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:79:3: table_field
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(79, 3);
				PushFollow(Follow._table_field_in_group604);
				table_field6=table_field();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, table_field6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:80:3: '(' exprList ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 6);
				char_literal7=(IToken)Match(input,31,Follow._31_in_group608); if (state.failed) return retval;
				DebugLocation(80, 8);
				PushFollow(Follow._exprList_in_group611);
				exprList8=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList8.Tree);
				DebugLocation(80, 20);
				char_literal9=(IToken)Match(input,32,Follow._32_in_group613); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 1, group_StartIndex); }
		}
		DebugLocation(81, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:83:1: mult : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 2);
		TraceIn("mult", 2);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);
		int mult_StartIndex = input.Index;
		object root_0 = null;

		IToken set11=null;
		MathLangParser.group_return group10 = default(MathLangParser.group_return);
		MathLangParser.group_return group12 = default(MathLangParser.group_return);

		object set11_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(83, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:83:5: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:83:7: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(83, 7);
			PushFollow(Follow._group_in_mult622);
			group10=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group10.Tree);
			DebugLocation(83, 13);
			// MathLang.g:83:13: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=MUL && LA2_0<=DIV)))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:83:15: ( MUL | DIV ) group
					{
					DebugLocation(83, 15);
					set11=(IToken)input.LT(1);
					set11=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set11), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(83, 30);
					PushFollow(Follow._group_in_mult637);
					group12=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group12.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 2);
			LeaveRule("mult", 2);
			Leave_mult();
			if (state.backtracking > 0) { Memoize(input, 2, mult_StartIndex); }
		}
		DebugLocation(83, 39);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:84:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 3);
		TraceIn("add", 3);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set14=null;
		MathLangParser.mult_return mult13 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult15 = default(MathLangParser.mult_return);

		object set14_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(84, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:84:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:84:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 7);
			PushFollow(Follow._mult_in_add649);
			mult13=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult13.Tree);
			DebugLocation(84, 13);
			// MathLang.g:84:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=ADD && LA3_0<=SUB)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:15: ( ADD | SUB ) mult
					{
					DebugLocation(84, 15);
					set14=(IToken)input.LT(1);
					set14=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set14), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(84, 30);
					PushFollow(Follow._mult_in_add665);
					mult15=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult15.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 3);
			LeaveRule("add", 3);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 3, add_StartIndex); }
		}
		DebugLocation(84, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:85:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 4);
		TraceIn("compare", 4);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set17=null;
		MathLangParser.add_return add16 = default(MathLangParser.add_return);
		MathLangParser.add_return add18 = default(MathLangParser.add_return);

		object set17_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(85, 64);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:85:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:85:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 10);
			PushFollow(Follow._add_in_compare677);
			add16=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add16.Tree);
			DebugLocation(85, 14);
			// MathLang.g:85:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			int alt4=2;
			try { DebugEnterSubRule(4);
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if (((LA4_0>=GE && LA4_0<=LT)))
			{
				alt4=1;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:85:16: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(85, 16);
				set17=(IToken)input.LT(1);
				set17=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set17), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(85, 57);
				PushFollow(Follow._add_in_compare707);
				add18=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add18.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 4);
			LeaveRule("compare", 4);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 4, compare_StartIndex); }
		}
		DebugLocation(85, 64);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:86:1: term : compare ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 5);
		TraceIn("term", 5);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.compare_return compare19 = default(MathLangParser.compare_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(86, 15);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:86:5: ( compare )
			DebugEnterAlt(1);
			// MathLang.g:86:7: compare
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 7);
			PushFollow(Follow._compare_in_term718);
			compare19=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare19.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 5);
			LeaveRule("term", 5);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 5, term_StartIndex); }
		}
		DebugLocation(86, 15);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class table_field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_table_field();
	partial void Leave_table_field();

	// $ANTLR start "table_field"
	// MathLang.g:88:1: table_field : ( ( FIELD DOT ( FIELD | '*' ) ) | FIELD );
	[GrammarRule("table_field")]
	private MathLangParser.table_field_return table_field()
	{
		Enter_table_field();
		EnterRule("table_field", 6);
		TraceIn("table_field", 6);
		MathLangParser.table_field_return retval = new MathLangParser.table_field_return();
		retval.Start = (IToken)input.LT(1);
		int table_field_StartIndex = input.Index;
		object root_0 = null;

		IToken FIELD20=null;
		IToken DOT21=null;
		IToken set22=null;
		IToken FIELD23=null;

		object FIELD20_tree=null;
		object DOT21_tree=null;
		object set22_tree=null;
		object FIELD23_tree=null;

		try { DebugEnterRule(GrammarFileName, "table_field");
		DebugLocation(88, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:88:12: ( ( FIELD DOT ( FIELD | '*' ) ) | FIELD )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==FIELD))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1==DOT))
				{
					alt5=1;
				}
				else if ((LA5_1==EOF||LA5_1==FROM||LA5_1==ORDER_BY||(LA5_1>=ADD && LA5_1<=LT)||(LA5_1>=32 && LA5_1<=34)))
				{
					alt5=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:88:14: ( FIELD DOT ( FIELD | '*' ) )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 14);
				// MathLang.g:88:14: ( FIELD DOT ( FIELD | '*' ) )
				DebugEnterAlt(1);
				// MathLang.g:88:15: FIELD DOT ( FIELD | '*' )
				{
				DebugLocation(88, 15);
				FIELD20=(IToken)Match(input,FIELD,Follow._FIELD_in_table_field728); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD20_tree = (object)adaptor.Create(FIELD20);
				adaptor.AddChild(root_0, FIELD20_tree);
				}
				DebugLocation(88, 24);
				DOT21=(IToken)Match(input,DOT,Follow._DOT_in_table_field730); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				DOT21_tree = (object)adaptor.Create(DOT21);
				root_0 = (object)adaptor.BecomeRoot(DOT21_tree, root_0);
				}
				DebugLocation(88, 26);
				set22=(IToken)input.LT(1);
				if (input.LA(1)==FIELD||input.LA(1)==MUL)
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set22));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:88:43: FIELD
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(88, 43);
				FIELD23=(IToken)Match(input,FIELD,Follow._FIELD_in_table_field744); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD23_tree = (object)adaptor.Create(FIELD23);
				adaptor.AddChild(root_0, FIELD23_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("table_field", 6);
			LeaveRule("table_field", 6);
			Leave_table_field();
			if (state.backtracking > 0) { Memoize(input, 6, table_field_StartIndex); }
		}
		DebugLocation(88, 47);
		} finally { DebugExitRule(GrammarFileName, "table_field"); }
		return retval;

	}
	// $ANTLR end "table_field"

	public class request_params_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_request_params();
	partial void Leave_request_params();

	// $ANTLR start "request_params"
	// MathLang.g:89:1: request_params : ( '*' | table_field );
	[GrammarRule("request_params")]
	private MathLangParser.request_params_return request_params()
	{
		Enter_request_params();
		EnterRule("request_params", 7);
		TraceIn("request_params", 7);
		MathLangParser.request_params_return retval = new MathLangParser.request_params_return();
		retval.Start = (IToken)input.LT(1);
		int request_params_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal24=null;
		MathLangParser.table_field_return table_field25 = default(MathLangParser.table_field_return);

		object char_literal24_tree=null;

		try { DebugEnterRule(GrammarFileName, "request_params");
		DebugLocation(89, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:89:16: ( '*' | table_field )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==MUL))
			{
				alt6=1;
			}
			else if ((LA6_0==FIELD))
			{
				alt6=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:18: '*'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(89, 18);
				char_literal24=(IToken)Match(input,MUL,Follow._MUL_in_request_params751); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal24_tree = (object)adaptor.Create(char_literal24);
				adaptor.AddChild(root_0, char_literal24_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:24: table_field
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(89, 24);
				PushFollow(Follow._table_field_in_request_params755);
				table_field25=table_field();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, table_field25.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("request_params", 7);
			LeaveRule("request_params", 7);
			Leave_request_params();
			if (state.backtracking > 0) { Memoize(input, 7, request_params_StartIndex); }
		}
		DebugLocation(89, 34);
		} finally { DebugExitRule(GrammarFileName, "request_params"); }
		return retval;

	}
	// $ANTLR end "request_params"

	public class formal_params_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_formal_params();
	partial void Leave_formal_params();

	// $ANTLR start "formal_params"
	// MathLang.g:90:1: formal_params : ( request_params ( ',' request_params )* ) -> ^( FIELDS ( request_params )+ ) ;
	[GrammarRule("formal_params")]
	private MathLangParser.formal_params_return formal_params()
	{
		Enter_formal_params();
		EnterRule("formal_params", 8);
		TraceIn("formal_params", 8);
		MathLangParser.formal_params_return retval = new MathLangParser.formal_params_return();
		retval.Start = (IToken)input.LT(1);
		int formal_params_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal27=null;
		MathLangParser.request_params_return request_params26 = default(MathLangParser.request_params_return);
		MathLangParser.request_params_return request_params28 = default(MathLangParser.request_params_return);

		object char_literal27_tree=null;
		RewriteRuleITokenStream stream_33=new RewriteRuleITokenStream(adaptor,"token 33");
		RewriteRuleSubtreeStream stream_request_params=new RewriteRuleSubtreeStream(adaptor,"rule request_params");
		try { DebugEnterRule(GrammarFileName, "formal_params");
		DebugLocation(90, 84);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:90:14: ( ( request_params ( ',' request_params )* ) -> ^( FIELDS ( request_params )+ ) )
			DebugEnterAlt(1);
			// MathLang.g:90:16: ( request_params ( ',' request_params )* )
			{
			DebugLocation(90, 16);
			// MathLang.g:90:16: ( request_params ( ',' request_params )* )
			DebugEnterAlt(1);
			// MathLang.g:90:18: request_params ( ',' request_params )*
			{
			DebugLocation(90, 18);
			PushFollow(Follow._request_params_in_formal_params763);
			request_params26=request_params();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_request_params.Add(request_params26.Tree);
			DebugLocation(90, 33);
			// MathLang.g:90:33: ( ',' request_params )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==33))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:90:34: ',' request_params
					{
					DebugLocation(90, 34);
					char_literal27=(IToken)Match(input,33,Follow._33_in_formal_params766); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_33.Add(char_literal27);

					DebugLocation(90, 38);
					PushFollow(Follow._request_params_in_formal_params768);
					request_params28=request_params();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_request_params.Add(request_params28.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}



			{
			// AST REWRITE
			// elements: request_params
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 90:57: -> ^( FIELDS ( request_params )+ )
			{
				DebugLocation(90, 60);
				// MathLang.g:90:60: ^( FIELDS ( request_params )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(90, 62);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELDS, "FIELDS"), root_1);

				DebugLocation(90, 69);
				if ( !(stream_request_params.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_request_params.HasNext )
				{
					DebugLocation(90, 69);
					adaptor.AddChild(root_1, stream_request_params.NextTree());

				}
				stream_request_params.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("formal_params", 8);
			LeaveRule("formal_params", 8);
			Leave_formal_params();
			if (state.backtracking > 0) { Memoize(input, 8, formal_params_StartIndex); }
		}
		DebugLocation(90, 84);
		} finally { DebugExitRule(GrammarFileName, "formal_params"); }
		return retval;

	}
	// $ANTLR end "formal_params"

	public class select__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_select_();
	partial void Leave_select_();

	// $ANTLR start "select_"
	// MathLang.g:91:1: select_ : SELECT formal_params ;
	[GrammarRule("select_")]
	private MathLangParser.select__return select_()
	{
		Enter_select_();
		EnterRule("select_", 9);
		TraceIn("select_", 9);
		MathLangParser.select__return retval = new MathLangParser.select__return();
		retval.Start = (IToken)input.LT(1);
		int select__StartIndex = input.Index;
		object root_0 = null;

		IToken SELECT29=null;
		MathLangParser.formal_params_return formal_params30 = default(MathLangParser.formal_params_return);

		object SELECT29_tree=null;

		try { DebugEnterRule(GrammarFileName, "select_");
		DebugLocation(91, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:91:8: ( SELECT formal_params )
			DebugEnterAlt(1);
			// MathLang.g:91:10: SELECT formal_params
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 16);
			SELECT29=(IToken)Match(input,SELECT,Follow._SELECT_in_select_787); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			SELECT29_tree = (object)adaptor.Create(SELECT29);
			root_0 = (object)adaptor.BecomeRoot(SELECT29_tree, root_0);
			}
			DebugLocation(91, 18);
			PushFollow(Follow._formal_params_in_select_790);
			formal_params30=formal_params();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formal_params30.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("select_", 9);
			LeaveRule("select_", 9);
			Leave_select_();
			if (state.backtracking > 0) { Memoize(input, 9, select__StartIndex); }
		}
		DebugLocation(91, 30);
		} finally { DebugExitRule(GrammarFileName, "select_"); }
		return retval;

	}
	// $ANTLR end "select_"

	public class tables_or_request_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tables_or_request();
	partial void Leave_tables_or_request();

	// $ANTLR start "tables_or_request"
	// MathLang.g:93:1: tables_or_request : ( FIELD | '(' exprList ')' );
	[GrammarRule("tables_or_request")]
	private MathLangParser.tables_or_request_return tables_or_request()
	{
		Enter_tables_or_request();
		EnterRule("tables_or_request", 10);
		TraceIn("tables_or_request", 10);
		MathLangParser.tables_or_request_return retval = new MathLangParser.tables_or_request_return();
		retval.Start = (IToken)input.LT(1);
		int tables_or_request_StartIndex = input.Index;
		object root_0 = null;

		IToken FIELD31=null;
		IToken char_literal32=null;
		IToken char_literal34=null;
		MathLangParser.exprList_return exprList33 = default(MathLangParser.exprList_return);

		object FIELD31_tree=null;
		object char_literal32_tree=null;
		object char_literal34_tree=null;

		try { DebugEnterRule(GrammarFileName, "tables_or_request");
		DebugLocation(93, 45);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:93:18: ( FIELD | '(' exprList ')' )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==FIELD))
			{
				alt8=1;
			}
			else if ((LA8_0==31))
			{
				alt8=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:93:20: FIELD
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 20);
				FIELD31=(IToken)Match(input,FIELD,Follow._FIELD_in_tables_or_request797); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD31_tree = (object)adaptor.Create(FIELD31);
				adaptor.AddChild(root_0, FIELD31_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:93:28: '(' exprList ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 31);
				char_literal32=(IToken)Match(input,31,Follow._31_in_tables_or_request801); if (state.failed) return retval;
				DebugLocation(93, 33);
				PushFollow(Follow._exprList_in_tables_or_request804);
				exprList33=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList33.Tree);
				DebugLocation(93, 45);
				char_literal34=(IToken)Match(input,32,Follow._32_in_tables_or_request806); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tables_or_request", 10);
			LeaveRule("tables_or_request", 10);
			Leave_tables_or_request();
			if (state.backtracking > 0) { Memoize(input, 10, tables_or_request_StartIndex); }
		}
		DebugLocation(93, 45);
		} finally { DebugExitRule(GrammarFileName, "tables_or_request"); }
		return retval;

	}
	// $ANTLR end "tables_or_request"

	public class request_tables_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_request_tables();
	partial void Leave_request_tables();

	// $ANTLR start "request_tables"
	// MathLang.g:94:1: request_tables : ( tables_or_request ( ',' tables_or_request )* ) -> ^( TABLES ( tables_or_request )+ ) ;
	[GrammarRule("request_tables")]
	private MathLangParser.request_tables_return request_tables()
	{
		Enter_request_tables();
		EnterRule("request_tables", 11);
		TraceIn("request_tables", 11);
		MathLangParser.request_tables_return retval = new MathLangParser.request_tables_return();
		retval.Start = (IToken)input.LT(1);
		int request_tables_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal36=null;
		MathLangParser.tables_or_request_return tables_or_request35 = default(MathLangParser.tables_or_request_return);
		MathLangParser.tables_or_request_return tables_or_request37 = default(MathLangParser.tables_or_request_return);

		object char_literal36_tree=null;
		RewriteRuleITokenStream stream_33=new RewriteRuleITokenStream(adaptor,"token 33");
		RewriteRuleSubtreeStream stream_tables_or_request=new RewriteRuleSubtreeStream(adaptor,"rule tables_or_request");
		try { DebugEnterRule(GrammarFileName, "request_tables");
		DebugLocation(94, 92);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:94:15: ( ( tables_or_request ( ',' tables_or_request )* ) -> ^( TABLES ( tables_or_request )+ ) )
			DebugEnterAlt(1);
			// MathLang.g:94:17: ( tables_or_request ( ',' tables_or_request )* )
			{
			DebugLocation(94, 17);
			// MathLang.g:94:17: ( tables_or_request ( ',' tables_or_request )* )
			DebugEnterAlt(1);
			// MathLang.g:94:18: tables_or_request ( ',' tables_or_request )*
			{
			DebugLocation(94, 18);
			PushFollow(Follow._tables_or_request_in_request_tables814);
			tables_or_request35=tables_or_request();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_tables_or_request.Add(tables_or_request35.Tree);
			DebugLocation(94, 36);
			// MathLang.g:94:36: ( ',' tables_or_request )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0==33))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:94:37: ',' tables_or_request
					{
					DebugLocation(94, 37);
					char_literal36=(IToken)Match(input,33,Follow._33_in_request_tables817); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_33.Add(char_literal36);

					DebugLocation(94, 41);
					PushFollow(Follow._tables_or_request_in_request_tables819);
					tables_or_request37=tables_or_request();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_tables_or_request.Add(tables_or_request37.Tree);

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }


			}



			{
			// AST REWRITE
			// elements: tables_or_request
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 94:62: -> ^( TABLES ( tables_or_request )+ )
			{
				DebugLocation(94, 65);
				// MathLang.g:94:65: ^( TABLES ( tables_or_request )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(94, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TABLES, "TABLES"), root_1);

				DebugLocation(94, 74);
				if ( !(stream_tables_or_request.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_tables_or_request.HasNext )
				{
					DebugLocation(94, 74);
					adaptor.AddChild(root_1, stream_tables_or_request.NextTree());

				}
				stream_tables_or_request.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("request_tables", 11);
			LeaveRule("request_tables", 11);
			Leave_request_tables();
			if (state.backtracking > 0) { Memoize(input, 11, request_tables_StartIndex); }
		}
		DebugLocation(94, 92);
		} finally { DebugExitRule(GrammarFileName, "request_tables"); }
		return retval;

	}
	// $ANTLR end "request_tables"

	public class from__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_from_();
	partial void Leave_from_();

	// $ANTLR start "from_"
	// MathLang.g:95:1: from_ : FROM request_tables ;
	[GrammarRule("from_")]
	private MathLangParser.from__return from_()
	{
		Enter_from_();
		EnterRule("from_", 12);
		TraceIn("from_", 12);
		MathLangParser.from__return retval = new MathLangParser.from__return();
		retval.Start = (IToken)input.LT(1);
		int from__StartIndex = input.Index;
		object root_0 = null;

		IToken FROM38=null;
		MathLangParser.request_tables_return request_tables39 = default(MathLangParser.request_tables_return);

		object FROM38_tree=null;

		try { DebugEnterRule(GrammarFileName, "from_");
		DebugLocation(95, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:95:6: ( FROM request_tables )
			DebugEnterAlt(1);
			// MathLang.g:95:8: FROM request_tables
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 12);
			FROM38=(IToken)Match(input,FROM,Follow._FROM_in_from_837); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FROM38_tree = (object)adaptor.Create(FROM38);
			root_0 = (object)adaptor.BecomeRoot(FROM38_tree, root_0);
			}
			DebugLocation(95, 14);
			PushFollow(Follow._request_tables_in_from_840);
			request_tables39=request_tables();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, request_tables39.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("from_", 12);
			LeaveRule("from_", 12);
			Leave_from_();
			if (state.backtracking > 0) { Memoize(input, 12, from__StartIndex); }
		}
		DebugLocation(95, 27);
		} finally { DebugExitRule(GrammarFileName, "from_"); }
		return retval;

	}
	// $ANTLR end "from_"

	public class orderby_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_orderby();
	partial void Leave_orderby();

	// $ANTLR start "orderby"
	// MathLang.g:97:1: orderby : ORDER_BY NUMBER ;
	[GrammarRule("orderby")]
	private MathLangParser.orderby_return orderby()
	{
		Enter_orderby();
		EnterRule("orderby", 13);
		TraceIn("orderby", 13);
		MathLangParser.orderby_return retval = new MathLangParser.orderby_return();
		retval.Start = (IToken)input.LT(1);
		int orderby_StartIndex = input.Index;
		object root_0 = null;

		IToken ORDER_BY40=null;
		IToken NUMBER41=null;

		object ORDER_BY40_tree=null;
		object NUMBER41_tree=null;

		try { DebugEnterRule(GrammarFileName, "orderby");
		DebugLocation(97, 25);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:97:8: ( ORDER_BY NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:97:10: ORDER_BY NUMBER
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 18);
			ORDER_BY40=(IToken)Match(input,ORDER_BY,Follow._ORDER_BY_in_orderby847); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ORDER_BY40_tree = (object)adaptor.Create(ORDER_BY40);
			root_0 = (object)adaptor.BecomeRoot(ORDER_BY40_tree, root_0);
			}
			DebugLocation(97, 20);
			NUMBER41=(IToken)Match(input,NUMBER,Follow._NUMBER_in_orderby850); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			NUMBER41_tree = (object)adaptor.Create(NUMBER41);
			adaptor.AddChild(root_0, NUMBER41_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("orderby", 13);
			LeaveRule("orderby", 13);
			Leave_orderby();
			if (state.backtracking > 0) { Memoize(input, 13, orderby_StartIndex); }
		}
		DebugLocation(97, 25);
		} finally { DebugExitRule(GrammarFileName, "orderby"); }
		return retval;

	}
	// $ANTLR end "orderby"

	public class where__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_where_();
	partial void Leave_where_();

	// $ANTLR start "where_"
	// MathLang.g:99:1: where_ : WHERE term ;
	[GrammarRule("where_")]
	private MathLangParser.where__return where_()
	{
		Enter_where_();
		EnterRule("where_", 14);
		TraceIn("where_", 14);
		MathLangParser.where__return retval = new MathLangParser.where__return();
		retval.Start = (IToken)input.LT(1);
		int where__StartIndex = input.Index;
		object root_0 = null;

		IToken WHERE42=null;
		MathLangParser.term_return term43 = default(MathLangParser.term_return);

		object WHERE42_tree=null;

		try { DebugEnterRule(GrammarFileName, "where_");
		DebugLocation(99, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:99:7: ( WHERE term )
			DebugEnterAlt(1);
			// MathLang.g:99:9: WHERE term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 14);
			WHERE42=(IToken)Match(input,WHERE,Follow._WHERE_in_where_857); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHERE42_tree = (object)adaptor.Create(WHERE42);
			root_0 = (object)adaptor.BecomeRoot(WHERE42_tree, root_0);
			}
			DebugLocation(99, 16);
			PushFollow(Follow._term_in_where_860);
			term43=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term43.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("where_", 14);
			LeaveRule("where_", 14);
			Leave_where_();
			if (state.backtracking > 0) { Memoize(input, 14, where__StartIndex); }
		}
		DebugLocation(100, 0);
		} finally { DebugExitRule(GrammarFileName, "where_"); }
		return retval;

	}
	// $ANTLR end "where_"

	public class expr1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr1();
	partial void Leave_expr1();

	// $ANTLR start "expr1"
	// MathLang.g:102:1: expr1 : select_ from_ expr2 ;
	[GrammarRule("expr1")]
	private MathLangParser.expr1_return expr1()
	{
		Enter_expr1();
		EnterRule("expr1", 15);
		TraceIn("expr1", 15);
		MathLangParser.expr1_return retval = new MathLangParser.expr1_return();
		retval.Start = (IToken)input.LT(1);
		int expr1_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.select__return select_44 = default(MathLangParser.select__return);
		MathLangParser.from__return from_45 = default(MathLangParser.from__return);
		MathLangParser.expr2_return expr246 = default(MathLangParser.expr2_return);


		try { DebugEnterRule(GrammarFileName, "expr1");
		DebugLocation(102, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:102:6: ( select_ from_ expr2 )
			DebugEnterAlt(1);
			// MathLang.g:103:3: select_ from_ expr2
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 3);
			PushFollow(Follow._select__in_expr1870);
			select_44=select_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, select_44.Tree);
			DebugLocation(104, 3);
			PushFollow(Follow._from__in_expr1874);
			from_45=from_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, from_45.Tree);
			DebugLocation(105, 3);
			PushFollow(Follow._expr2_in_expr1878);
			expr246=expr2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr246.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr1", 15);
			LeaveRule("expr1", 15);
			Leave_expr1();
			if (state.backtracking > 0) { Memoize(input, 15, expr1_StartIndex); }
		}
		DebugLocation(106, 0);
		} finally { DebugExitRule(GrammarFileName, "expr1"); }
		return retval;

	}
	// $ANTLR end "expr1"

	public class expr2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr2();
	partial void Leave_expr2();

	// $ANTLR start "expr2"
	// MathLang.g:108:1: expr2 : ( where_ )? ( orderby )? ;
	[GrammarRule("expr2")]
	private MathLangParser.expr2_return expr2()
	{
		Enter_expr2();
		EnterRule("expr2", 16);
		TraceIn("expr2", 16);
		MathLangParser.expr2_return retval = new MathLangParser.expr2_return();
		retval.Start = (IToken)input.LT(1);
		int expr2_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.where__return where_47 = default(MathLangParser.where__return);
		MathLangParser.orderby_return orderby48 = default(MathLangParser.orderby_return);


		try { DebugEnterRule(GrammarFileName, "expr2");
		DebugLocation(108, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:108:6: ( ( where_ )? ( orderby )? )
			DebugEnterAlt(1);
			// MathLang.g:109:3: ( where_ )? ( orderby )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 3);
			// MathLang.g:109:3: ( where_ )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==WHERE))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: where_
				{
				DebugLocation(109, 3);
				PushFollow(Follow._where__in_expr2888);
				where_47=where_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, where_47.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(10); }

			DebugLocation(110, 3);
			// MathLang.g:110:3: ( orderby )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==ORDER_BY))
			{
				alt11=1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: orderby
				{
				DebugLocation(110, 3);
				PushFollow(Follow._orderby_in_expr2893);
				orderby48=orderby();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orderby48.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(11); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr2", 16);
			LeaveRule("expr2", 16);
			Leave_expr2();
			if (state.backtracking > 0) { Memoize(input, 16, expr2_StartIndex); }
		}
		DebugLocation(111, 0);
		} finally { DebugExitRule(GrammarFileName, "expr2"); }
		return retval;

	}
	// $ANTLR end "expr2"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:113:1: exprList : ( expr1 ) -> ^( BLOCK expr1 ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 17);
		TraceIn("exprList", 17);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);
		int exprList_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.expr1_return expr149 = default(MathLangParser.expr1_return);

		RewriteRuleSubtreeStream stream_expr1=new RewriteRuleSubtreeStream(adaptor,"rule expr1");
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(113, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:113:9: ( ( expr1 ) -> ^( BLOCK expr1 ) )
			DebugEnterAlt(1);
			// MathLang.g:114:4: ( expr1 )
			{
			DebugLocation(114, 4);
			// MathLang.g:114:4: ( expr1 )
			DebugEnterAlt(1);
			// MathLang.g:114:6: expr1
			{
			DebugLocation(114, 6);
			PushFollow(Follow._expr1_in_exprList907);
			expr149=expr1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr1.Add(expr149.Tree);

			}



			{
			// AST REWRITE
			// elements: expr1
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 114:14: -> ^( BLOCK expr1 )
			{
				DebugLocation(114, 17);
				// MathLang.g:114:17: ^( BLOCK expr1 )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(114, 19);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(114, 25);
				adaptor.AddChild(root_1, stream_expr1.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 17);
			LeaveRule("exprList", 17);
			Leave_exprList();
			if (state.backtracking > 0) { Memoize(input, 17, exprList_StartIndex); }
		}
		DebugLocation(115, 0);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class requestList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_requestList();
	partial void Leave_requestList();

	// $ANTLR start "requestList"
	// MathLang.g:117:1: requestList : ( exprList ( ';' ) ) -> ^( REQUEST exprList ) ;
	[GrammarRule("requestList")]
	private MathLangParser.requestList_return requestList()
	{
		Enter_requestList();
		EnterRule("requestList", 18);
		TraceIn("requestList", 18);
		MathLangParser.requestList_return retval = new MathLangParser.requestList_return();
		retval.Start = (IToken)input.LT(1);
		int requestList_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal51=null;
		MathLangParser.exprList_return exprList50 = default(MathLangParser.exprList_return);

		object char_literal51_tree=null;
		RewriteRuleITokenStream stream_34=new RewriteRuleITokenStream(adaptor,"token 34");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "requestList");
		DebugLocation(117, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:117:12: ( ( exprList ( ';' ) ) -> ^( REQUEST exprList ) )
			DebugEnterAlt(1);
			// MathLang.g:118:2: ( exprList ( ';' ) )
			{
			DebugLocation(118, 2);
			// MathLang.g:118:2: ( exprList ( ';' ) )
			DebugEnterAlt(1);
			// MathLang.g:118:3: exprList ( ';' )
			{
			DebugLocation(118, 3);
			PushFollow(Follow._exprList_in_requestList927);
			exprList50=exprList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_exprList.Add(exprList50.Tree);
			DebugLocation(118, 12);
			// MathLang.g:118:12: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:118:13: ';'
			{
			DebugLocation(118, 13);
			char_literal51=(IToken)Match(input,34,Follow._34_in_requestList930); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_34.Add(char_literal51);


			}


			}



			{
			// AST REWRITE
			// elements: exprList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 118:20: -> ^( REQUEST exprList )
			{
				DebugLocation(118, 23);
				// MathLang.g:118:23: ^( REQUEST exprList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(118, 25);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(REQUEST, "REQUEST"), root_1);

				DebugLocation(118, 33);
				adaptor.AddChild(root_1, stream_exprList.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("requestList", 18);
			LeaveRule("requestList", 18);
			Leave_requestList();
			if (state.backtracking > 0) { Memoize(input, 18, requestList_StartIndex); }
		}
		DebugLocation(119, 0);
		} finally { DebugExitRule(GrammarFileName, "requestList"); }
		return retval;

	}
	// $ANTLR end "requestList"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:121:1: program : requestList ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 19);
		TraceIn("program", 19);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);
		int program_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.requestList_return requestList52 = default(MathLangParser.requestList_return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(121, 22);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:121:8: ( requestList )
			DebugEnterAlt(1);
			// MathLang.g:121:10: requestList
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(121, 10);
			PushFollow(Follow._requestList_in_program949);
			requestList52=requestList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, requestList52.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 19);
			LeaveRule("program", 19);
			Leave_program();
			if (state.backtracking > 0) { Memoize(input, 19, program_StartIndex); }
		}
		DebugLocation(121, 22);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:123:1: result : program EOF ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 20);
		TraceIn("result", 20);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);
		int result_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF54=null;
		MathLangParser.program_return program53 = default(MathLangParser.program_return);

		object EOF54_tree=null;

		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(123, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:123:7: ( program EOF )
			DebugEnterAlt(1);
			// MathLang.g:123:9: program EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(123, 9);
			PushFollow(Follow._program_in_result958);
			program53=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program53.Tree);
			DebugLocation(123, 20);
			EOF54=(IToken)Match(input,EOF,Follow._EOF_in_result960); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 20);
			LeaveRule("result", 20);
			Leave_result();
			if (state.backtracking > 0) { Memoize(input, 20, result_StartIndex); }
		}
		DebugLocation(123, 20);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:125:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 21);
		TraceIn("execute", 21);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);
		int execute_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.result_return result55 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(125, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:125:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:126:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 3);
			PushFollow(Follow._result_in_execute972);
			result55=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result55.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 21);
			LeaveRule("execute", 21);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 21, execute_StartIndex); }
		}
		DebugLocation(127, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _31_in_group586 = new BitSet(new ulong[]{0x80070000UL});
		public static readonly BitSet _term_in_group589 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _32_in_group591 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group596 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TEXT_in_group600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _table_field_in_group604 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _31_in_group608 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _exprList_in_group611 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _32_in_group613 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult622 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _set_in_mult626 = new BitSet(new ulong[]{0x80070000UL});
		public static readonly BitSet _group_in_mult637 = new BitSet(new ulong[]{0xC00002UL});
		public static readonly BitSet _mult_in_add649 = new BitSet(new ulong[]{0x300002UL});
		public static readonly BitSet _set_in_add654 = new BitSet(new ulong[]{0x80070000UL});
		public static readonly BitSet _mult_in_add665 = new BitSet(new ulong[]{0x300002UL});
		public static readonly BitSet _add_in_compare677 = new BitSet(new ulong[]{0x3F000002UL});
		public static readonly BitSet _set_in_compare681 = new BitSet(new ulong[]{0x80070000UL});
		public static readonly BitSet _add_in_compare707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_term718 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_table_field728 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _DOT_in_table_field730 = new BitSet(new ulong[]{0x420000UL});
		public static readonly BitSet _set_in_table_field733 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_table_field744 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MUL_in_request_params751 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _table_field_in_request_params755 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _request_params_in_formal_params763 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _33_in_formal_params766 = new BitSet(new ulong[]{0x420000UL});
		public static readonly BitSet _request_params_in_formal_params768 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _SELECT_in_select_787 = new BitSet(new ulong[]{0x420000UL});
		public static readonly BitSet _formal_params_in_select_790 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_tables_or_request797 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _31_in_tables_or_request801 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _exprList_in_tables_or_request804 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _32_in_tables_or_request806 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _tables_or_request_in_request_tables814 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _33_in_request_tables817 = new BitSet(new ulong[]{0x80020000UL});
		public static readonly BitSet _tables_or_request_in_request_tables819 = new BitSet(new ulong[]{0x200000002UL});
		public static readonly BitSet _FROM_in_from_837 = new BitSet(new ulong[]{0x80020000UL});
		public static readonly BitSet _request_tables_in_from_840 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ORDER_BY_in_orderby847 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _NUMBER_in_orderby850 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHERE_in_where_857 = new BitSet(new ulong[]{0x80070000UL});
		public static readonly BitSet _term_in_where_860 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _select__in_expr1870 = new BitSet(new ulong[]{0x20UL});
		public static readonly BitSet _from__in_expr1874 = new BitSet(new ulong[]{0xC0UL});
		public static readonly BitSet _expr2_in_expr1878 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _where__in_expr2888 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _orderby_in_expr2893 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr1_in_exprList907 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _exprList_in_requestList927 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_requestList930 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _requestList_in_program949 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result958 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result960 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute972 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
