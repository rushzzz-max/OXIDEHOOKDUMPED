using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public class RJButton : Button
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	// (set) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Category("RJ Code Advance")]
	public int BorderSize
	{
		get
		{
			return this.borderSize;
		}
		set
		{
			this.borderSize = value;
			base.Invalidate();
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x0000205F File Offset: 0x0000025F
	// (set) Token: 0x06000004 RID: 4 RVA: 0x00002067 File Offset: 0x00000267
	[Category("RJ Code Advance")]
	public int BorderRadius
	{
		get
		{
			return this.borderRadius;
		}
		set
		{
			this.borderRadius = value;
			base.Invalidate();
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002076 File Offset: 0x00000276
	// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
	[Category("RJ Code Advance")]
	public Color BorderColor
	{
		get
		{
			return this.borderColor;
		}
		set
		{
			this.borderColor = value;
			base.Invalidate();
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000007 RID: 7 RVA: 0x0000208D File Offset: 0x0000028D
	// (set) Token: 0x06000008 RID: 8 RVA: 0x00002095 File Offset: 0x00000295
	[Category("RJ Code Advance")]
	public Color BackgroundColor
	{
		get
		{
			return this.BackColor;
		}
		set
		{
			this.BackColor = value;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000009 RID: 9 RVA: 0x0000209E File Offset: 0x0000029E
	// (set) Token: 0x0600000A RID: 10 RVA: 0x000020A6 File Offset: 0x000002A6
	[Category("RJ Code Advance")]
	public Color TextColor
	{
		get
		{
			return this.ForeColor;
		}
		set
		{
			this.ForeColor = value;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002248 File Offset: 0x00000448
	public RJButton()
	{
		base.FlatStyle = FlatStyle.Flat;
		base.FlatAppearance.BorderSize = 0;
		base.Size = new Size(150, 40);
		this.BackColor = Color.MediumSlateBlue;
		this.ForeColor = Color.White;
		base.Resize += this.Button_Resize;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020AF File Offset: 0x000002AF
	private void Button_Resize(object sender, EventArgs e)
	{
		if (this.borderRadius > base.Height)
		{
			this.borderRadius = base.Height;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000022BC File Offset: 0x000004BC
	private GraphicsPath GetFigurePath(Rectangle rect, float radius)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		float num = radius * 2f;
		graphicsPath.StartFigure();
		graphicsPath.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		graphicsPath.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002374 File Offset: 0x00000574
	protected override void OnPaint(PaintEventArgs pevent)
	{
		base.OnPaint(pevent);
		Rectangle clientRectangle = base.ClientRectangle;
		Rectangle rect = Rectangle.Inflate(clientRectangle, -this.borderSize, -this.borderSize);
		int num = 2;
		if (this.borderSize > 0)
		{
			num = this.borderSize;
		}
		if (this.borderRadius > 2)
		{
			using (GraphicsPath figurePath = this.GetFigurePath(clientRectangle, (float)this.borderRadius))
			{
				using (GraphicsPath figurePath2 = this.GetFigurePath(rect, (float)(this.borderRadius - this.borderSize)))
				{
					using (Pen pen = new Pen(base.Parent.BackColor, (float)num))
					{
						using (Pen pen2 = new Pen(this.borderColor, (float)this.borderSize))
						{
							pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
							base.Region = new Region(figurePath);
							pevent.Graphics.DrawPath(pen, figurePath);
							if (this.borderSize >= 1)
							{
								pevent.Graphics.DrawPath(pen2, figurePath2);
							}
							return;
						}
					}
				}
			}
		}
		pevent.Graphics.SmoothingMode = SmoothingMode.None;
		base.Region = new Region(clientRectangle);
		if (this.borderSize >= 1)
		{
			using (Pen pen3 = new Pen(this.borderColor, (float)this.borderSize))
			{
				pen3.Alignment = PenAlignment.Inset;
				pevent.Graphics.DrawRectangle(pen3, 0, 0, base.Width - 1, base.Height - 1);
			}
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020CB File Offset: 0x000002CB
	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		base.Parent.BackColorChanged += this.Container_BackColorChanged;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020EB File Offset: 0x000002EB
	private void Container_BackColorChanged(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	// Token: 0x04000001 RID: 1
	private int borderSize;

	// Token: 0x04000002 RID: 2
	private int borderRadius = 20;

	// Token: 0x04000003 RID: 3
	private Color borderColor = Color.PaleVioletRed;
}
