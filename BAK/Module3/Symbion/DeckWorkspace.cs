﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Symbion {
	public partial class DeckWorkspace : BaseWorkspace {
		protected Dictionary<IView, DeckButton> _views;
		protected List<DeckButton> _queue;
		protected DeckButton _activeButton;

		public DeckWorkspace() {
			InitializeComponent();
			_views = new Dictionary<IView, DeckButton>();
			_queue = new List<DeckButton>();
		}

		protected void OnItemClick(object sender, EventArgs e) {
			ActivateNewButton((DeckButton)sender);
		}
		private void btnActive_Click(object sender, EventArgs e) {
			if (_queue.Count > 0) ActivateNewButton(_queue[0]);
		}
		protected void SetActiveButton(DeckButton item) {
			IView view = (IView)item.Tag;
			view.Control.Dock = DockStyle.Fill;
			viewPanel.Controls.Add(view.Control);
			btnActive.Text = view.Caption;
			btnActive.Image = view.Icon;
			btnActive.Enabled = true;
			_activeButton = item;
		}
		protected void ActivateNewButton(DeckButton item) {
			if (_activeButton != null) {
				IView view = (IView)_activeButton.Tag;
				viewPanel.Controls.Remove(view.Control);
				Controls.Add(_activeButton);
				_queue.Add(_activeButton);
			}
			_queue.Remove(item);
			Controls.Remove(item);
			SetActiveButton(item);
		}

		public override void Append(IView view) {
			DeckButton item = new DeckButton(view);
			item.Click += OnItemClick;
			if (_views.Count == 0) SetActiveButton(item); else {
				_queue.Add(item); Controls.Add(item);
			}
			_views.Add(view, item);
			view.Workspace = this;
		}
		public override void Remove(IView view) {
			DeckButton item = _views[view];
			if (item == _activeButton) {
				_activeButton = null;
				viewPanel.Controls.Remove(view.Control);
				if (_queue.Count == 0) {
					btnActive.Image = null;
					btnActive.Text = string.Empty;
					btnActive.Enabled = false;
				}
				else ActivateNewButton(_queue[0]);
			}
			else {
				Controls.Remove(item);
				_queue.Remove(item);
			}
			_views.Remove(view);
			view.Workspace = null;
		}

		public override void Update(IView view) {
			DeckButton item = _views[view];
			item.Image = view.Icon;
			item.Text = view.Caption;
			if (_activeButton.Tag == view)
				SetActiveButton(item);
		}
	}
}
