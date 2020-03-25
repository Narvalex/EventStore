﻿using System;

namespace EventStore.Core.Messages {
	public class ScavengeResultDto {
		public string ScavengeId { get; set; }

		public ScavengeResultDto() {
		}

		public ScavengeResultDto(string scavengeId) {
			ScavengeId = scavengeId;
		}

		public override string ToString() {
			return String.Format("ScavengeId: {0}", ScavengeId);
		}
	}
}
