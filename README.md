# UI Toolkit Text Sizing Bug

This project demonstrates that Unity's UI Toolkit does not consistently size text at arbitrary screen resolutions. A label with identical content and styling can word-wrap differently depending on the pixel width/height of the window, even when the difference is just one pixel. I've added a side-by-side comparison of the behavior between TextCore and ATG engines. ATG greatly improves the text wrapping stability at higher resolutions, but still has issues at certain text sizes and window resolutions.

## How to Reproduce

1. Open the `SampleScene` in Unity
2. Build and run the project
3. The script lerps the resolution between 400px and 700px wide every 3 seconds
4. Observe the text wrapping unpredictably
5. ATG is much more stable, but still has issues

## Demo

https://github.com/user-attachments/assets/f19dd628-441b-46a2-afbf-b67aa38f14c9
