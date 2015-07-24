# YawDriftChecker
Project for testing Oculus Yaw Drift
Oculusの（OVRCameraRig/TrackingSpace/CenterEyeAnchorの）Yawドリフトをチェックするプロジェクトです。

# 使い方
Oculusを接続して、机の上等において動かさないようにしてから、プロジェクトを動かします。
1秒ごとにCenterEyeAnchorのy軸回転をAssets/Log.csvに出力します。
触っていなくてもどの程度動いているかを観察してみましょう。

# 動作環境
* Unity 5.1.2p1
* Oculus SDK 0.6.0.1

# 動作確認環境
* Oculus Rift DK2（ポジショントラッキング：有）
* Oculus Rift DK2（ポジショントラッキング：無）
