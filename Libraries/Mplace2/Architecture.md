

# Presentation

## Setting a Page specific presentation

Member Page specifies that the display presentation is MemberPresentation
~~~~
    MemberPage Page "MemberPage"
        FlowPage Container
        Navigation Is MainNav
        MainEntry Is User
            Display MemberPresentation
~~~~

This is mapped to a specific presentation in the FramePage class. This arrangement allows a 
list of entries of different type to be presented in a format appropriate to that page.


~~~~
public partial class FramePage {

    public static FramePresentation? MemberPresentation(IBinding data) => data switch {
        User => User.MemberSummary,
        _ => null
        };
    }
~~~~


