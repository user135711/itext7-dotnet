using System.Collections.Generic;
using iText.Kernel.Geom;
using iText.Layout.Margincollapse;

namespace iText.Layout.Layout {
    /// <summary>
    /// Represents the context for content of a line
    /// <see cref="iText.Layout.Renderer.IRenderer.Layout(LayoutContext)">layouting</see>
    /// .
    /// </summary>
    public class LineLayoutContext : LayoutContext {
        private bool floatOverflowedToNextPageWithNothing = false;

        private float textIndent;

        public LineLayoutContext(LayoutArea area, MarginsCollapseInfo marginsCollapseInfo, IList<Rectangle> floatedRendererAreas
            , bool clippedHeight)
            : base(area, marginsCollapseInfo, floatedRendererAreas, clippedHeight) {
        }

        public LineLayoutContext(LayoutContext layoutContext)
            : base(layoutContext.area, layoutContext.marginsCollapseInfo, layoutContext.floatRendererAreas, layoutContext
                .clippedHeight) {
        }

        /// <summary>
        /// Specifies whether some floating element within the same paragraph has already completely overflowed to the next
        /// page.
        /// </summary>
        /// <returns>true if floating element has already overflowed to the next page, false otherwise.</returns>
        public virtual bool IsFloatOverflowedToNextPageWithNothing() {
            return floatOverflowedToNextPageWithNothing;
        }

        /// <summary>
        /// Changes the value of property specified by
        /// <see cref="IsFloatOverflowedToNextPageWithNothing()"/>
        /// .
        /// </summary>
        /// <param name="floatOverflowedToNextPageWithNothing">true if some floating element already completely overflowed.
        ///     </param>
        /// <returns>
        /// this
        /// <see cref="LineLayoutContext"/>
        /// instance.
        /// </returns>
        public virtual iText.Layout.Layout.LineLayoutContext SetFloatOverflowedToNextPageWithNothing(bool floatOverflowedToNextPageWithNothing
            ) {
            this.floatOverflowedToNextPageWithNothing = floatOverflowedToNextPageWithNothing;
            return this;
        }

        /// <summary>Gets the indent of text in the beginning of the current line.</summary>
        /// <returns>the indent of text in this line.</returns>
        public virtual float GetTextIndent() {
            return textIndent;
        }

        /// <summary>Sets the indent of text in the beginning of the current line.</summary>
        /// <param name="textIndent">the indent of text in this line.</param>
        /// <returns>
        /// this
        /// <see cref="LineLayoutContext"/>
        /// instance.
        /// </returns>
        public virtual iText.Layout.Layout.LineLayoutContext SetTextIndent(float textIndent) {
            this.textIndent = textIndent;
            return this;
        }
    }
}
