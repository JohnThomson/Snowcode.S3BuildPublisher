# S3BuildPublisher (https://github.com/JohnThomson/Snowcode.S3BuildPublisher.git)

MSBuild AWS (Amazon Web Services) Task Library

***

## Source

This is a fork of an SVN repository at http://snowcode.googlecode.com/svn/trunk/2010-04-TramDepot/Snowcode.S3BuildPublisher/.
It was forked at revision 131.

See http://blog.analysisuk.com/post/MSBuild-AWS-Task-Library.aspx for documentation and history

## What I've changed

I removed the restriction that S3 publish tasks cannot work with a bucket whose names contain periods.

This required updating the code to the latest version of AWSSDK (2.0.13 at the time), so I made minimum changes to get it compile.

Warning: I have not had time to test tasks other than basic S3 upload to see whether my changes work. The original author is hoping to do a fuller version of this patch. I recommend checking the original repository, https://github.com/JohnThomson/Snowcode.S3BuildPublisher.git. In the meantime, I'm giving you what I have.

Currently, the change to allow periods in bucket names requires being explicit about the region. See the code that sets RegionEndpoint in the S3Helper constructor. It is currently hard-coded to USEast1. If that doesn't work for you, you will need to change it (or introduce some way of configuring it).

## Building

Currently requires visual studio 2010 with nuget installed.

You may have to manually run the package manager and get the one required package, AWS SDK for .NET (2.0.13).

Then just build the solution.

## License

See License.txt. Microsoft Public License (Ms-PL)
