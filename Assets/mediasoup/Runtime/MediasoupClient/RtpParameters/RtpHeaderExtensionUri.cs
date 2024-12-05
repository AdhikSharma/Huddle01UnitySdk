using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Mediasoup.RtpParameter
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RtpHeaderExtensionUri : byte
    {
        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:sdes:mid")]
        Mid = 0,

        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:sdes:rtp-stream-id")]
        RtpStreamId = 1,

        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:sdes:repaired-rtp-stream-id")]
        RepairRtpStreamId = 2,

        [EnumMember(Value = "http://tools.ietf.org/html/draft-ietf-avtext-framemarking-07")]
        FrameMarkingDraft07 = 3,

        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:framemarking")]
        FrameMarking = 4,

        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:ssrc-audio-level")]
        AudioLevel = 5,

        [EnumMember(Value = "urn:3gpp:video-orientation")]
        VideoOrientation = 6,

        [EnumMember(Value = "urn:ietf:params:rtp-hdrext:toffset")]
        TimeOffset = 7,

        [EnumMember(Value = "http://www.ietf.org/id/draft-holmer-rmcat-transport-wide-cc-extensions-01")]
        TransportWideCcDraft01 = 8,

        [EnumMember(Value = "http://www.webrtc.org/experiments/rtp-hdrext/abs-send-time")]
        AbsSendTime = 9,

        [EnumMember(Value = "http://www.webrtc.org/experiments/rtp-hdrext/abs-capture-time")]
        AbsCaptureTime = 10,
    }
}