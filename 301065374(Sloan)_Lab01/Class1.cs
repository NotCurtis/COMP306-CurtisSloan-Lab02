using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace _301065374_Sloan__Lab01
{
    class Class1
	{
        public static List<obj> bl = new List<obj>();
        public class obj
		{
            public string BucketName { get; set; }
            public DateTime CreationDate { get; set; }
		}

        public List<obj> getList()
		{
            GetBucketList();
            return bl;
        }

        private static async void GetBucketList()
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);

            var accessKeyID = builder.Build().GetSection("AWSCredentials").GetSection("AccesskeyID").Value;
            var secretKey = builder.Build().GetSection("AWSCredentials").GetSection("Secretaccesskey").Value;

            var credentials = new BasicAWSCredentials(accessKeyID, secretKey);

            //List<obj> bl = new List<obj>();

            using (AmazonS3Client s3Client = new AmazonS3Client(credentials, RegionEndpoint.USEast1))
            {
                ListBucketsResponse response = await s3Client.ListBucketsAsync();
                foreach (S3Bucket bucket in response.Buckets)
                {
                    //Console.WriteLine(bucket.BucketName + " " + bucket.CreationDate.ToShortDateString());
                    bl.Add(new obj() { BucketName = bucket.BucketName, CreationDate = bucket.CreationDate });
                    Console.WriteLine("Item Added to List.");
                }
            }
        }
    }
}
