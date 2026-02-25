using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections;
namespace DesignPattern.BehaviouralDesignPatterns.ObserverPattern
{
    interface ISubscriber
    {
        void update();
    }

    // Observable interface: a YouTube channel interface
    interface IChannel
    {
        void subscribe(ISubscriber subscriber);
        void unsubscribe(ISubscriber subscriber);
        void notifySubscribers();
    }

    // Concrete Subject: a YouTube channel that observers can subscribe to
    class Channel : IChannel
    {
        private List<ISubscriber> subscribers;
        private String name;
        private String latestVideo;

        public Channel(String name)
        {
            this.name = name;
            this.subscribers = new List<ISubscriber>();
        }


        public void subscribe(ISubscriber subscriber)
        {
            if (!subscribers.Contains(subscriber))
            {
                subscribers.Add(subscriber);
            }
        }


        public void unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }


        public void notifySubscribers()
        {
            foreach (ISubscriber sub in subscribers)
            {
                sub.update();
            }
        }

        public void uploadVideo(String title)
        {
            latestVideo = title;
            Console.WriteLine("\n[" + name + " uploaded \"" + title + "\"]");
            notifySubscribers();
        }

        public String getVideoData()
        {
            return "\nCheckout our new Video : " + latestVideo + "\n";
        }
    }

    // Concrete Observer: represents a subscriber to the channel
    class Subscriber : ISubscriber
    {
        private String name;
        private Channel channel;

        public Subscriber(String name, Channel channel)
        {
            this.name = name;
            this.channel = channel;
        }


        public void update()
        {
            Console.WriteLine("Hey " + name + "," + channel.getVideoData());
        }
    }

    public class ObserverDesignPattern
    {
        public static void main()
        {
            // Create a channel and subscribers
            Channel channel = new Channel("CoderArmy");

            Subscriber subs1 = new Subscriber("Varun", channel);
            Subscriber subs2 = new Subscriber("Tarun", channel);

            // Varun and Tarun subscribe to CoderArmy
            channel.subscribe(subs1);
            channel.subscribe(subs2);

            // Upload a video: both Varun and Tarun are notified
            channel.uploadVideo("Observer Pattern Tutorial");

            // Varun unsubscribes; Tarun remains subscribed
            channel.unsubscribe(subs1);

            // Upload another video: only Tarun is notified
            channel.uploadVideo("Decorator Pattern Tutorial");
        }
    }
}