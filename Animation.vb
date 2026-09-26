Imports System.IO



Namespace RSDKv1
    Public Class Animation(Of ICloneable)
        Public Function Clone()
            Return MemberwiseClone()
        End Function


        ' <summary>
        ' the Default names For the animations
        ' </summary>
        Private Shared ReadOnly animationNames
        Dim Stopped
        Dim Waiting
        Dim Bored!
        Dim LookingUp
        Dim LookingDown
        Dim Walking
        Dim Running
        Dim Skidding
        Dim SuperPeelOut
        Dim SpinDash
        Dim Jumping
        Dim Bouncing
        Dim Hurt
        Dim Dying
        Dim LifeIcon
        Dim Drowning
        Dim FanRotate
        Dim Breathing
        Dim Pushing
        Dim FlailingLeft
        Dim FlailingRight
        Dim Sliding
        Dim Hanging
        Dim Dropping
        Dim FinishPose
        Dim CorkScrew
        Dim RetroSonicAnimation26
        Dim FlyTired
        Dim Climbing
        Dim LedgePullUp
        Dim GlideSlide
        Dim BonusSpin
        Dim SpecialStop
        Dim SpecialWalk
        Dim SpecialJump

        Public Enum PlayerIDs
            Sonic
            Tails
            Knuckles
        End Enum
    End Class
    Public Class AnimationEntry(Of ICloneable)
        Public Function Clone()
            Return MemberwiseClone()
        End Function
    End Class
    Public Class Frame(Of ICloneable)
        Public Function Clone()
            Return MemberwiseClone()
        End Function
    End Class

    Public Structure Hitbox
        Public Left As SByte
        Public Right As SByte
        Public Up As SByte
        Public Down As SByte
    End Structure








End Namespace





